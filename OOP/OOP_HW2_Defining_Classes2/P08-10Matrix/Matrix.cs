using System;
using System.Linq;

namespace P08_10Matrix
{
	public class Matrix<T> where T: IComparable
	{
		#region Fields
		private int rows;
		private int columns;
		private T[,] matrix;
		#endregion

		#region constructor
		public Matrix(int rows, int columns)
		{
			this.rows = rows;
			this.columns = columns;
			this.matrix = new T[rows, columns];
		}
		#endregion

		#region properties
		public int Rows
		{
			get { return this.rows; }
			set
			{
				if (value > 0 && value <= int.MaxValue)
				{
					this.rows = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("The number of rows provided is out Of the specified range.");
				}
			}
		}

		public int Columns
		{
			get { return this.columns; }
			set
			{
				if (value > 0 && value <= int.MaxValue)
				{
					this.columns = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("The number of columns provided is out Of the specified range.");
				}
			}
		}
		#endregion

		#region Indexer
		public T this[int row, int column]
		{
			get
			{
				if (row >= 0 && row <= this.rows && column >= 0 && column <= this.columns)
				{
					return matrix[row, column];
				}
				else
				{
					throw new IndexOutOfRangeException("Index Out Of Range Exception!");
				}
			}
			set
			{
				if (row <= this.rows && column <= this.columns)
				{
					this.matrix[row, column] = value;
				}
				else
				{
					throw new IndexOutOfRangeException("Index Out Of Range Exception!");
				}
			}
		}

		#endregion

		#region Operators

		public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
		{
			Matrix<T> matrixSum = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);

			if (firstMatrix.Columns != secondMatrix.Columns || firstMatrix.Rows != secondMatrix.Rows)
				throw new ArgumentException("Operation cannot be performed.");
			else
			{
				for (int i = 0; i < firstMatrix.Rows; i++)
				{
					for (int j = 0; j < firstMatrix.Columns; j++)
					{
						matrixSum[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
					}
				}
			}
			return matrixSum;
		}

		public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
		{
			Matrix<T> matrixSum = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);

			if (firstMatrix.Columns != secondMatrix.Columns || firstMatrix.Rows != secondMatrix.Rows)
				throw new ArgumentException("Operation cannot be performed.");
			else
			{
				for (int i = 0; i < firstMatrix.Rows; i++)
				{
					for (int j = 0; j < firstMatrix.Columns; j++)
					{
						matrixSum[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
					}
				}
			}
			return matrixSum;
		}

		public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
		{
			if (firstMatrix.Columns != secondMatrix.Rows)
				throw new ArgumentException("Colums of the first matrix should be equal to the rows of the second");
			
			var result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Columns);

			var rows = result.Rows;
			var columns = result.Columns;
			var multiplyIterations = firstMatrix.Columns;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					for (int p = 0; p < multiplyIterations; p++)
					{
						result[i, j] += (dynamic)firstMatrix[i, p] * (dynamic)secondMatrix[p, j];
					}
				}
			}
			
			return result;
		}

		#endregion

		public void PrintMatrix(string matrixName)
		{
			Console.WriteLine("{0}: ",matrixName);
			for (int row = 0; row < this.Rows; row++)
			{
				for (int col = 0; col < this.Columns; col++)
				{
					Console.Write("{0} ", matrix[row, col]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
