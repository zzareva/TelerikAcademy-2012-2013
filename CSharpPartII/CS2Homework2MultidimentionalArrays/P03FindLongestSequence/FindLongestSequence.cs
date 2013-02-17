using System;

class FindLongestSequence
{
	static void Main()
	{
		Console.WriteLine("Please enter the number of the number of the rows in the matrix:");
		int n = GetMatrixSize();
		Console.WriteLine("Please enter the number of the number of the columns in the matrix:");
		int m = GetMatrixSize();
		string[,] matrix = new string[n, m];
		for (int i = 0; i < n; i++)//row
		{
			for (int j = 0; j < m; j++)//column
			{
				Console.Write("Enter matrix[{0},{1}]:", i, j);
				matrix[i, j] = Console.ReadLine();
			}
		}
		string currentSequence = "";
		int currentLength = 0;
		string longestSequence = "";
		int maxLength = 0;
		string previousMember = "";
		string currentMember = "";

		//Check Columns
		for (int i = 0; i < n; i++)//row
		{
			currentLength = 0;
			currentSequence = "";
			previousMember = "";
			for (int j = 0; j < m; j++)//column
			{
				currentMember = matrix[i, j];
				if (matrix[i, j] == previousMember) 
				{
					currentSequence += (", " + currentMember);
					currentLength++;
				}
				else
				{
					currentLength = 1;
					currentSequence = currentMember;
				}
					previousMember = currentMember;
			}
			if(currentLength > maxLength)
			{
				maxLength = currentLength;
				longestSequence = currentSequence;
			}
		}

		//Check Rows
		for (int j = 0; j < m; j++)//column
		{
			currentLength = 0;
			currentSequence = "";
			previousMember = "";
			for (int i = 0; i < n; i++)//row
			{
				currentMember = matrix[i, j];
				if (matrix[i, j] == previousMember) 
				{
					currentSequence += (", " + currentMember);
					currentLength++;
				}
				else
				{
					currentLength = 1;
					currentSequence = currentMember;
				}
					previousMember = currentMember;
			}
			if(currentLength > maxLength)
			{
				maxLength = currentLength;
				longestSequence = currentSequence;
			}
		}

		//Check Diagonals - bottom left to top right
		int row = 0;
		int col = 0;
		for (int diagonalSum = 0; diagonalSum < n + m; diagonalSum++) //row
		{
			row = Math.Min(n - 1, diagonalSum);
			currentLength = 0;
			currentSequence = "";
			previousMember = "";
			while (row >= 0 && diagonalSum - row < m)
			{
				col = diagonalSum - row;
				currentMember = matrix[n - row - 1, col];
				if (currentMember == previousMember)
				{
					currentSequence += (", " + currentMember);
					currentLength++;
				}
				else
				{
					currentLength = 1;
					currentSequence = currentMember;
				}
				previousMember = currentMember;
				row--;
			}
			if (currentLength > maxLength)
			{
				maxLength = currentLength;
				longestSequence = currentSequence;
			}
		}

		//Check Diagonals - top left to bottom right
		row = 0;
		col = 0;
		for (int diagonalSum = 0; diagonalSum < n + m; diagonalSum++) //row
		{
			row = Math.Min(n - 1, diagonalSum);
			currentLength = 0;
			currentSequence = "";
			previousMember = "";
			while (row >= 0 && diagonalSum - row >= 0 && diagonalSum - row < m)
			{
				col = diagonalSum - row;
				currentMember = matrix[row, col];
				if (currentMember == previousMember)
				{
					currentSequence += (", " + currentMember);
					currentLength++;
				}
				else
				{
					currentLength = 1;
					currentSequence = currentMember;
				}
				previousMember = currentMember;
				row--;
			}
			if (currentLength > maxLength)
			{
				maxLength = currentLength;
				longestSequence = currentSequence;
			}
		}
		Console.WriteLine("The longest sequence is: {0}",longestSequence);
	}
	static int GetMatrixSize()
	{
		int number = 0;
		while (!int.TryParse(Console.ReadLine(), out number) || number < 3)
		{
			Console.ForegroundColor = System.ConsoleColor.Red;
			Console.WriteLine("Incorrect data input! Please privide a valid integer number > 3.");
			Console.ForegroundColor = System.ConsoleColor.Gray;
		}
		return number;
	}
}
