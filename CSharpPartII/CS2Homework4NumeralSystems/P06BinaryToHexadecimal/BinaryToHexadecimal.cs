using System;
using System.Text;

class BinaryToHexadecimal
{
	private static string ConvertToHexadecimal(string binNumber)
	{
		while (binNumber.Length % 4 != 0)
		{
			binNumber = "0" + binNumber;
		}

		StringBuilder hexNumber = new StringBuilder();
		for (int position = 0; position < binNumber.Length; position += 4)
		{
			string str = binNumber.Substring(position, 4);
			switch (str)
			{
				case "0000":
					hexNumber.Append("0");
					break;
				case "0001":
					hexNumber.Append("1");
					break;
				case "0010":
					hexNumber.Append("2");
					break;
				case "0011":
					hexNumber.Append("3");
					break;
				case "0100":
					hexNumber.Append("4");
					break;
				case "0101":
					hexNumber.Append("5");
					break;
				case "0110":
					hexNumber.Append("6");
					break;
				case "0111":
					hexNumber.Append("7");
					break;
				case "1000":
					hexNumber.Append("8");
					break;
				case "1001":
					hexNumber.Append("9");
					break;
				case "1010":
					hexNumber.Append("A");
					break;
				case "1011":
					hexNumber.Append("B");
					break;
				case "1100":
					hexNumber.Append("C");
					break;
				case "1101":
					hexNumber.Append("D");
					break;
				case "1110":
					hexNumber.Append("E");
					break;
				case "1111":
					hexNumber.Append("F");
					break;
				default:
					break;
			}
		}

		return hexNumber.ToString();
	}

	static void Main()
	{
		Console.WriteLine("Please enter the binary number:");
		string binaryNumber = Console.ReadLine();
		string hexadecimal = ConvertToHexadecimal(binaryNumber);
		Console.WriteLine("The heaxadecimal number is: {0}", hexadecimal);
	}
}
