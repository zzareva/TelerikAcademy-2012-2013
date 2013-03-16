using System;
using System.Linq;
using System.Text;

namespace P01Substring
{
	public static class ExtensionMethod
	{
		public static StringBuilder Substring(this StringBuilder input,int index, int length)
		{
			var resultStringBilder = new StringBuilder();
			var strInput = input.ToString();
			resultStringBilder.Append(strInput.Substring(index,length));
			return resultStringBilder;
		}
	}
}
