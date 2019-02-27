namespace mnemonic_last_word
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MnemonicLabel = new System.Windows.Forms.Label();
            this.MnemonicTextBox = new System.Windows.Forms.TextBox();
            this.LastWordTextBox = new System.Windows.Forms.TextBox();
            this.LastWordLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LastPrefixTextBox = new System.Windows.Forms.TextBox();
            this.LastPrefixLabel = new System.Windows.Forms.Label();
            this.ChecksumTextBox = new System.Windows.Forms.TextBox();
            this.ChecksumLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MnemonicLabel
            // 
            this.MnemonicLabel.AutoSize = true;
            this.MnemonicLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MnemonicLabel.Location = new System.Drawing.Point(25, 82);
            this.MnemonicLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MnemonicLabel.Name = "MnemonicLabel";
            this.MnemonicLabel.Size = new System.Drawing.Size(306, 36);
            this.MnemonicLabel.TabIndex = 6;
            this.MnemonicLabel.Text = "Mnemonic except last";
            // 
            // MnemonicTextBox
            // 
            this.MnemonicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MnemonicTextBox.Location = new System.Drawing.Point(340, 82);
            this.MnemonicTextBox.Multiline = true;
            this.MnemonicTextBox.Name = "MnemonicTextBox";
            this.MnemonicTextBox.Size = new System.Drawing.Size(492, 187);
            this.MnemonicTextBox.TabIndex = 1;
            // 
            // LastWordTextBox
            // 
            this.LastWordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastWordTextBox.Location = new System.Drawing.Point(340, 425);
            this.LastWordTextBox.Name = "LastWordTextBox";
            this.LastWordTextBox.ReadOnly = true;
            this.LastWordTextBox.Size = new System.Drawing.Size(492, 35);
            this.LastWordTextBox.TabIndex = 6;
            // 
            // LastWordLabel
            // 
            this.LastWordLabel.AutoSize = true;
            this.LastWordLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastWordLabel.Location = new System.Drawing.Point(187, 425);
            this.LastWordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastWordLabel.Name = "LastWordLabel";
            this.LastWordLabel.Size = new System.Drawing.Size(144, 36);
            this.LastWordLabel.TabIndex = 8;
            this.LastWordLabel.Text = "Last word";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CalculateButton.Location = new System.Drawing.Point(263, 527);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(150, 50);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HintLabel.Location = new System.Drawing.Point(37, 125);
            this.HintLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(294, 36);
            this.HintLabel.TabIndex = 10;
            this.HintLabel.Text = "(Seperated by space)";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearButton.Location = new System.Drawing.Point(431, 527);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 50);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LastPrefixTextBox
            // 
            this.LastPrefixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPrefixTextBox.Location = new System.Drawing.Point(340, 297);
            this.LastPrefixTextBox.Name = "LastPrefixTextBox";
            this.LastPrefixTextBox.Size = new System.Drawing.Size(492, 35);
            this.LastPrefixTextBox.TabIndex = 2;
            this.LastPrefixTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastPrefixTextBox_KeyPress);
            // 
            // LastPrefixLabel
            // 
            this.LastPrefixLabel.AutoSize = true;
            this.LastPrefixLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastPrefixLabel.Location = new System.Drawing.Point(12, 297);
            this.LastPrefixLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastPrefixLabel.Name = "LastPrefixLabel";
            this.LastPrefixLabel.Size = new System.Drawing.Size(319, 36);
            this.LastPrefixLabel.TabIndex = 13;
            this.LastPrefixLabel.Text = "Last word binary prefix";
            // 
            // ChecksumTextBox
            // 
            this.ChecksumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChecksumTextBox.Location = new System.Drawing.Point(340, 361);
            this.ChecksumTextBox.Name = "ChecksumTextBox";
            this.ChecksumTextBox.ReadOnly = true;
            this.ChecksumTextBox.Size = new System.Drawing.Size(492, 35);
            this.ChecksumTextBox.TabIndex = 5;
            // 
            // ChecksumLabel
            // 
            this.ChecksumLabel.AutoSize = true;
            this.ChecksumLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChecksumLabel.Location = new System.Drawing.Point(179, 361);
            this.ChecksumLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChecksumLabel.Name = "ChecksumLabel";
            this.ChecksumLabel.Size = new System.Drawing.Size(152, 36);
            this.ChecksumLabel.TabIndex = 15;
            this.ChecksumLabel.Text = "Checksum";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LanguageLabel.Location = new System.Drawing.Point(186, 18);
            this.LanguageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(145, 36);
            this.LanguageLabel.TabIndex = 16;
            this.LanguageLabel.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "English",
            "简体中文"});
            this.LanguageComboBox.Location = new System.Drawing.Point(340, 22);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(492, 32);
            this.LanguageComboBox.TabIndex = 17;
            this.LanguageComboBox.Tag = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 589);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.ChecksumTextBox);
            this.Controls.Add(this.ChecksumLabel);
            this.Controls.Add(this.LastPrefixTextBox);
            this.Controls.Add(this.LastPrefixLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.LastWordTextBox);
            this.Controls.Add(this.LastWordLabel);
            this.Controls.Add(this.MnemonicTextBox);
            this.Controls.Add(this.MnemonicLabel);
            this.MinimumSize = new System.Drawing.Size(870, 660);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mnemonic Last Word";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MnemonicLabel;
        private System.Windows.Forms.TextBox MnemonicTextBox;
        private System.Windows.Forms.TextBox LastWordTextBox;
        private System.Windows.Forms.Label LastWordLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox LastPrefixTextBox;
        private System.Windows.Forms.Label LastPrefixLabel;
        private System.Windows.Forms.TextBox ChecksumTextBox;
        private System.Windows.Forms.Label ChecksumLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
    }
}

