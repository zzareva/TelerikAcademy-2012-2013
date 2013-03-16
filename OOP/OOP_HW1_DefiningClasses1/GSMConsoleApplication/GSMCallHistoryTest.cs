using System;
using System.Linq;
using GSMData.Base;

namespace GSMConsoleApplication
{
	public class GSMCallHistoryTest
	{

		public GSM TestGSMInstance
		{
			get;
			private set;
		}

		public static void RunGSMCallHistoryTest()
		{
			AddCallsInHistory();
			testGSMInstance.DisplayCallsHistory();
			DisplayTotalPrice(0.37m);
			RemoveLongestCall();
			DisplayTotalPrice(0.37m);
			testGSMInstance.ClearCallHistory();
			testGSMInstance.DisplayCallsHistory();
		}

		private static readonly GSM testGSMInstance = new GSM("Q10", "Blackberry");

		private static void AddCallsInHistory()
		{
			testGSMInstance.AddCall(new Call(new DateTime(1994, 7, 10, 7, 10, 00), "987654321", 300));
			testGSMInstance.AddCall(new Call(new DateTime(1994, 7, 11, 9, 10, 00), "987654322", 120));
			testGSMInstance.AddCall(new Call(new DateTime(1994, 7, 12, 8, 10, 00), "987654323", 180));
			testGSMInstance.AddCall(new Call(new DateTime(1994, 7, 13, 11, 10, 00), "987654321", 60));
		}

		private static void DisplayTotalPrice(decimal price)
		{
			Console.WriteLine("The total price of the calls is: {0}", testGSMInstance.CalculateTotalPrice(price));
		}
		private static void RemoveLongestCall()
		{
			testGSMInstance.CallHistory.Sort((x, y) => x.CallDuration - y.CallDuration);
			testGSMInstance.CallHistory.RemoveAt(testGSMInstance.CallHistory.Count - 1);
			Console.WriteLine("The longest call is now removed.");
		}
	}
}
	