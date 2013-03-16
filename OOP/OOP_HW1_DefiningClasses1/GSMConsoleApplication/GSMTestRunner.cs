using System;
using System.Linq;
using GSMData.Base;

namespace GSMConsoleApplication
{
	class GSMTestRunner
	{
		static void Main()
		{
			Console.WriteLine("Enter 1 to run GSMTest or 2 to run GSMCallHistoryTest:");
			byte testNumber = 0;
			try
			{
				testNumber = byte.Parse(Console.ReadLine());
				if (testNumber == 1)
					GSMTest.RunGSMTest();
				else if(testNumber == 2)
					GSMCallHistoryTest.RunGSMCallHistoryTest();
				else
					throw new ArgumentException("Incorrect test number!");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
		}
	}
}
