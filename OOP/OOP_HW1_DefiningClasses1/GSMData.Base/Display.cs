using System;
using System.Linq;
using System.Text;

namespace GSMData.Base
{
	public class Display
	{
		private float size;
		private int numberOfColors;

		public Display(float size, int numberOfColors)
		{
			this.size = size;
			this.numberOfColors = numberOfColors;
		}

		public int NumberOfColors
		{
			get
			{
				return this.numberOfColors;
			}
			set
			{
				this.numberOfColors = value;
			}
		}

		public float Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}
		public override string ToString()
		{
			StringBuilder displayedString = new StringBuilder();
			displayedString.Append(size);
			displayedString.Append(", ");
			displayedString.Append(numberOfColors);
			return displayedString.ToString();
		}
	}
}
