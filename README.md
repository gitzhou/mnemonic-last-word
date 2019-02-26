# mnemonic-last-word

A tiny Windows desktop tool that calculate the last word of BIP39 Mnemonic.

## Why did this

Tool https://iancoleman.io/bip39/ is good and easy enough to generate mnemonic words directly or from the raw entropy.

Some friends told me that they don't know how to use it and wanna generate the words **directly** with some random and offline methods trusted by themselves.

However, Mnemonic contains checksum so they can't move forward and I made this.

## How to use

**Build the project by yourself (recommended) or only download file from `builds` directory in this repository.**

According to BIP39, the last word consist of two parts: some low bits of raw entropy and some high bits of checksum.

We can figure out the checksum length from the mnemonic word count then decide the length of last word prefix since each word has 11 bits.

Word Count | Checksum Length | Prefix Length
-----------| --------------- | ---------------
12     |        4        |        7
15     |        5        |        6
18     |        6        |        5
21     |        7        |        4
24     |        8        |        3

![Imgur](https://i.imgur.com/K8WvYb2l.png)

If I wanna 12 words

- Get the first 11 words with some random and offline methods that you trusted, fill in the words into [1]
- Fill in 7 random binary bits (according to the table) into [2]
- Click `Calculate` button

![Imgur](https://i.imgur.com/6R64pXcl.png)

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

