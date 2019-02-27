# mnemonic-last-word

A tiny Windows desktop tool that calculate the last word of BIP39 Mnemonic.

[中文版解释](https://aaron67.cc/2019/02/18/bitcoin-wallet-best-practice/#%E5%AE%89%E5%85%A8%E7%9A%84%E7%94%9F%E6%88%90%E5%8A%A9%E8%AE%B0%E8%AF%8D)

## Why did this

Tool https://iancoleman.io/bip39/ is good and easy enough to generate mnemonic words directly or from the raw entropy.

Some friends told me that they don't know how to use it and wanna generate the words **directly** with some random and offline methods trusted by themselves.

However, Mnemonic contains checksum so they can't move forward and I made this.

## How to use

**Build the project by yourself (recommended) or only download file from `builds` directory in this repository.**

**Run it offline when you actually use to avoid information leak.**

According to BIP39, the last word consist of two parts: some low bits of raw entropy and some high bits of checksum.

We can figure out the checksum length from the mnemonic word count then decide the length of last word prefix since each word has 11 bits.

Word Count | Checksum Length | Prefix Length
-----------| --------------- | ---------------
12     |        4        |        7
15     |        5        |        6
18     |        6        |        5
21     |        7        |        4
24     |        8        |        3

![Imgur](https://i.imgur.com/e9wIAzFl.png)

If I wanna 24 words

1. Select the language, currently support English and Chinese Simplified
2. Get the first 23 words with some random and offline methods that you trusted, fill in the words
3. According to the table, fill in 3 random binary bits as last word prefix
4. Click `Calculate` button

![Imgur](https://i.imgur.com/aLiSkp9l.png)

Use this tool at your own rish, reivew code or do some test before actually use it.

**I have no responsibility for any loss or damage.**

## What's next

Maybe multi-language word list support, or some other features. To be honest, I don't know.

If you have great ideas, issue and PR are very welcome. DEV based on .NET Framework 4.6.1

## Donation

Appreciated and THANK YOU :smile:

You can donate **Bitcoin**, **Bitcoin Cash** or **Bitcoin SV** to `13L81fdKqdif6AEFAfBymXdyB3hDvBvdp9` to buy me a cup of coffee :coffee:

![Imgur](https://i.imgur.com/oowYIk6.png)

## License

MIT

