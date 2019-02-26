using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace mnemonic_last_word
{
    public partial class MainForm : Form
    {
        private static readonly int TOTAL_WORD_COUNT_IN_LIST = 2048;
        private static readonly int[] VALID_MNEMONIC_WORD_COUNT = { 12, 15, 18, 21, 24 };
        private static readonly int BIT_LENGTH_PER_WORD = 11;

        private List<string> english = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoadMnemonic();
        }

        public void LoadMnemonic()
        {
            using (StreamReader sr = new StreamReader(@"wordlist\english.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    english.Add(line);
                }
            }
            if (english.Count != TOTAL_WORD_COUNT_IN_LIST)
            {
                MessageBox.Show("Mnemonic word list file is broken, please reset the file", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Choose a language
                List<string> wordList = english;

                // Validation of word list
                string[] words = MnemonicTextBox.Text.Trim().Split(' ');
                string checkMessage = IsWordsValid(words, wordList);
                if (checkMessage != "")
                {
                    MessageBox.Show(checkMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validation of the last word prefix
                string lastWordPrefix = LastPrefixTextBox.Text.Trim();
                int validPrefixLength = GetValidPrefixLength(words.Length);
                if (lastWordPrefix.Length != validPrefixLength)
                {
                    MessageBox.Show("The length of last word prefix should be " + validPrefixLength, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // We're good here

                // Calculate word index
                List<int> wordIndex = new List<int>();
                foreach (string word in words)
                {
                    wordIndex.Add(wordList.IndexOf(word));
                }
                // Calculate cresponding binary stream of word index
                StringBuilder builder = new StringBuilder();
                foreach (int index in wordIndex)
                {

                    builder.Append(Convert.ToString(index, 2).PadLeft(BIT_LENGTH_PER_WORD, '0'));
                }
                // Got the raw entropy
                builder.Append(lastWordPrefix);
                string entropy = builder.ToString();
                // Calculate SHA256 of raw entropy
                byte[] hash = new SHA256Managed().ComputeHash(BinaryStringToBytes(entropy));
                // Got the checksum of mnemonic
                int checksumLength = BIT_LENGTH_PER_WORD - validPrefixLength;
                string checksum = BytesToBinaryString(hash).Substring(0, checksumLength);
                ChecksumTextBox.Text = checksum;
                // Got the index of last word, append prefix with checksum
                int lastWordIndex = Convert.ToInt32(lastWordPrefix + checksum, 2);
                // Locate last word in list
                LastWordTextBox.Text = wordList[lastWordIndex];
            }
            catch
            {
                MessageBox.Show("Unknown exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string IsWordsValid(string[] words, List<string> wordList)
        {
            // Validation of word count
            if (Array.IndexOf(VALID_MNEMONIC_WORD_COUNT, words.Length + 1) < 0)
            {
                return "The word count is not correct";
            }
            // Each word should be in the list
            foreach (string word in words)
            {
                if (wordList.IndexOf(word) < 0)
                {
                    return "Word " + word + " is invalid";
                }
            }
            // Word list is good here
            return "";
        }

        // According to BIP39
        // the last word consist of two parts
        // some low bits of raw entropy and some high bits of checksum
        // We can figure out the checksum length from the mnemonic word count
        // then decide the length of last word prefix since each word has 11 bits
        //
        //  Word Count | Checksum Length | Prefix Length
        // ----------- | --------------- | ---------------
        //     12      |        4        |        7
        //     15      |        5        |        6
        //     18      |        6        |        5
        //     21      |        7        |        4
        //     24      |        8        |        3
        private int GetValidPrefixLength(int wordCount)
        {
            return BIT_LENGTH_PER_WORD - (wordCount + 1) / 3;
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            MnemonicTextBox.Text = "";
            LastPrefixTextBox.Text = "";
            ChecksumTextBox.Text = "";
            LastWordTextBox.Text = "";
        }

        private void LastPrefixTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only accept 0, 1, backspace and delete
            if (e.KeyChar == '0' || e.KeyChar == '1' || (Keys)(e.KeyChar) == Keys.Back || (Keys)(e.KeyChar) == Keys.Delete)
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        #region Conversion methods of byte array and string of binary format

        private static byte[] BinaryStringToBytes(string binString)
        {
            int BITS_OF_BYTE = 8;
            binString = binString.Replace(" ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
            while ((binString.Length % BITS_OF_BYTE) != 0)
            {
                binString = "0" + binString;
            }
            byte[] bytes = new byte[binString.Length / BITS_OF_BYTE];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(binString.Substring(i * BITS_OF_BYTE, BITS_OF_BYTE), 2);
            }
            return bytes;
        }

        private static string BytesToBinaryString(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            return builder.ToString();
        }

        #endregion
    }
}
