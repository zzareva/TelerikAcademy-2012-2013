using System;

class PrintASCIITable
{
	static void Main()
	{
		//Console.OutputEncoding = System.Text.Encoding.ASCII;
		System.Console.OutputEncoding = System.Text.Encoding.UTF8;
		string hexValue = "";
		Console.Write("\tDecimal\t");
		Console.Write("ASCII\t");
		Console.Write("\tHex\n");

		for (int decValue = 0; decValue <= 127; decValue++)
		{
			hexValue = "00" + decValue.ToString("X");
			char charValue = (char)decValue;
			Console.Write("\t" + decValue + "\t");
			if (char.IsWhiteSpace(charValue))
			{
				switch (charValue)
				{
					case '\t':
						Console.Write("\\t");
						break;
					case ' ':
						Console.Write("space");
						break;
					case '\n':
						Console.Write("\\n");
						break;
					case '\r':
						Console.Write("\\r");
						break;
					case '\v':
						Console.Write("\\v");
						break;
					case '\f':
						Console.Write("\\f");
						break;
				}
			}
			else if (char.IsControl(charValue))
			{
				Console.Write("control");
			}
			else
			{
				Console.Write(charValue);
			}
			Console.Write("\t\t" + hexValue + "\n");
		}
		Console.Write("\n");
	}
}
