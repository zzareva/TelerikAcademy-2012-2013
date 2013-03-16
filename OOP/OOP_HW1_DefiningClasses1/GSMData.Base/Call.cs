using System;
using System.Linq;
using System.Text;

namespace GSMData.Base
{
	public class Call
	{
		public DateTime Date { get; set; }
		public string DialedPhoneNumber { get; set; }
		public int CallDuration { get; set; }
		
		public Call(DateTime date, string dialedPhoneNumber, int duration)
		{
			this.Date = date;
			this.DialedPhoneNumber = dialedPhoneNumber;
			this.CallDuration = duration;
		}
		public override string ToString()
		{
			StringBuilder callInfo = new StringBuilder();
			callInfo.Append("call date: ");
			callInfo.Append(Date);
			callInfo.Append(", diales number: ");
			callInfo.Append(DialedPhoneNumber);
			callInfo.Append(", duration (s): ");
			callInfo.Append(CallDuration);

			return callInfo.ToString();
		}
	}
}
