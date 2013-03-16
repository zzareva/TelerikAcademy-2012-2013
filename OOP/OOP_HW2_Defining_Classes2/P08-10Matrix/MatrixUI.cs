using System;
using System.Linq;

namespace P08_10Matrix
{
	class MatrixUI
	{
		static void Main()
		{
			Matrix<decimal> exampleMatrix1 = new Matrix<decimal>(2, 3);
			Matrix<decimal> exampleMatrix2 = new Matrix<decimal>(3, 2);

			exampleMatrix1[0, 0] = 1m;
			exampleMatrix1[0, 1] = 2m;
			exampleMatrix1[0, 2] = 3;
			exampleMatrix1[1, 0] = 4;
			exampleMatrix1[1, 1] = 5m;
			exampleMatrix1[1, 2] = 6;
			exampleMatrix1.PrintMatrix("Input Matrix 1");

			exampleMatrix2[0, 0] = 10;
			exampleMatrix2[0, 1] = 11;
			exampleMatrix2[1, 0] = 12;
			exampleMatrix2[1, 1] = 13;
			exampleMatrix2[2, 0] = 14;
			exampleMatrix2[2, 1] = 15;
			exampleMatrix2.PrintMatrix("Input Matrix 2");


			Matrix<decimal> multiplicationResult = new Matrix<decimal>(exampleMatrix1.Rows, exampleMatrix2.Columns);
			multiplicationResult = exampleMatrix1 * exampleMatrix2;

			multiplicationResult.PrintMatrix("Multiplication Result");

			exampleMatrix1 = new Matrix<decimal>(2, 2);
			exampleMatrix2 = new Matrix<decimal>(2, 2);

			exampleMatrix1[0, 0] = 1.4m;
			exampleMatrix1[0, 1] = 2.25m;
			exampleMatrix1[1, 0] = 4;
			exampleMatrix1[1, 1] = 5.10m;
			exampleMatrix1.PrintMatrix("Input Matrix 1");

			exampleMatrix2[0, 0] = 10;
			exampleMatrix2[0, 1] = 11;
			exampleMatrix2[1, 0] = 12;
			exampleMatrix2[1, 1] = 13;
			exampleMatrix2.PrintMatrix("Input Matrix 2");


			Matrix<decimal> resultMatrix = new Matrix<decimal>(exampleMatrix1.Rows, exampleMatrix2.Columns);
			
			resultMatrix = exampleMatrix1 + exampleMatrix2;
			resultMatrix.PrintMatrix("Sum Result");

			resultMatrix = exampleMatrix1 - exampleMatrix2;
			resultMatrix.PrintMatrix("Substraction Result");

		}
	}
}
