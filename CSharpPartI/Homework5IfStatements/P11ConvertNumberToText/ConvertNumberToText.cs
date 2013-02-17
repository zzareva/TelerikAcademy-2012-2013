using System;

class ConvertNumberToText
{
	static void Main()
	{
		Console.WriteLine("Please enter a number in the range [0-999].");
		int number;
		while(!int.TryParse(Console.ReadLine(),out number) || number < 0 || number > 999)
		{
			Console.WriteLine("Please enter a number in the range [0-999].");
		}
		int[] digits = new int[3];
		digits[0] = number % 10;
		string[] singleDigits = {"zero","one","two","three","four","five","six","seven","eight","nine"};
		string singleDigit = singleDigits[digits[0]];
		string numberText = singleDigit;
		if (number > 10)
		{
			digits[1] = (number / 10) % 10;
			string[] teenTexts = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
			string[] decimalTexts = {"twenty", "thirty", "forty", "fifty"};
			string decimalText = "";
			switch (digits[1])
			{
				case 1:
					decimalText = teenTexts[digits[0]];
					break;
				case 2:
				case 3:
				case 4:
				case 5:
					decimalText = decimalTexts[digits[1] - 2];
					break;
				case 6:
				case 7:
				case 8:
				case 9:
					decimalText = singleDigits[digits[1]] + "ty";
					break;
				default:
					break;
			}
			numberText = decimalText;

			if(digits[1] > 1 && digits[0] != 0)
			{
				numberText += "-" + singleDigit;
			}
			else if (digits[1] == 0 && digits[0] != 0)
			{
				numberText = singleDigit;
			}
		}
		if (number > 99)
		{
			digits[2] = number / 100;
			if (digits[1] == 0 && digits[0] == 0)
			{
				numberText = singleDigits[digits[2]] + " hundred";
			}
			else if ((digits[1] == 0 && digits[0] != 0) || digits[1] == 1)
			{
				numberText = singleDigits[digits[2]] + " hundred and " + numberText;
			}
			else
			{
				numberText = singleDigits[digits[2]] + " hundred " + numberText;
			}
		}
		Console.WriteLine(numberText.Substring(0,1).ToUpper() + numberText.Substring(1));
	}
}