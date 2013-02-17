using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EncoderDecoder
{
	private static string Encode(string key, string input)
	{
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < input.Length; i++ )
		{
			sb.Append((char)(input[i] ^ key[i % key.Length]));
		}
		return sb.ToString();
	}
	private static string Decode(string key, string input)
	{
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < input.Length; i++)
		{
			sb.Append((char)(input[i] ^ key[i % key.Length]));
		}
		return sb.ToString();
	}

	static void Main()
	{
		Console.WriteLine("PLease enter the cipher");
		string cipher = Console.ReadLine();
		Console.WriteLine("Please enter the string");
		string text = Console.ReadLine();
		string encoded = Encode(cipher, text);
		Console.WriteLine("Encoded: {0}", encoded);
		string decoded = Decode(cipher, encoded);
		Console.WriteLine("Decoded: {0}", decoded);
	}
}
