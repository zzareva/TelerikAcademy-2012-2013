using System;
using System.Linq;
using System.Text;

namespace GSMData.Base
{
	public class Battery
	{
		private string model;
		private float hoursIdle;
		private float hoursTalk;
		private BatteryType typeOfBattery;
		
		public Battery(string model, float hoursIdle, float hoursTalk)
		{
			this.model = model;
			this.hoursIdle = hoursIdle;
			this.hoursTalk = hoursTalk;
		}

		public string Model
		{
			get
			{
				return this.model;
			}
			set
			{
				this.model = value;
			}
		}

		public float HoursIdle
		{
			get
			{
				return this.hoursIdle;
			}
			set
			{
				this.hoursIdle = value;
			}
		}

		public float HoursTalk
		{
			get
			{
				return this.hoursTalk;
			}
			set
			{
				this.hoursTalk = value;
			}
		}

		public BatteryType TypeOfBattery
		{
			get
			{
				return this.typeOfBattery;
			}
			set
			{
				this.typeOfBattery = value;
			}
		}
		public override string ToString()
		{
			StringBuilder displayedString = new StringBuilder();
			displayedString.Append(model);
			displayedString.Append(", ");
			displayedString.Append(hoursIdle);
			displayedString.Append(", ");
			displayedString.Append(typeOfBattery);
			return displayedString.ToString();
		}
	}
}
