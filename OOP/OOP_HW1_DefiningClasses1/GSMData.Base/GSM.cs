using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace GSMData.Base
{
	public class GSM
	{
		#region Constructors
		private GSM()
		{
		}

		public GSM(string model, string manufacturer)
		{
			this.model = model;
			this.manufacturer = manufacturer;

			CallHistory = new List<Call>();
		}

		public GSM(string model, string manufacturer, int price)
			: this(model, manufacturer)
		{
			this.price = price;
		}

		public GSM(string model, string manufacturer, int price, Battery batteryCharacteristics, Display displayCharacterisctics)
			: this(model, manufacturer, price)
		{
			this.batteryCharacteristics = batteryCharacteristics;
			this.displayCharacterisctics = displayCharacterisctics;
		}

		public GSM(string model, string manufacturer, int price, string owner, Battery batteryCharacteristics, Display displayCharacterisctics)
			: this(model, manufacturer, price, batteryCharacteristics, displayCharacterisctics)
		{
			this.owner = owner;
		}
		#endregion

		#region Public Properties
		public static GSM IPhone4S
		{
			get
			{
				return iPhone4S;
			}
		}

		public string Model
		{
			get
			{
				return this.model;
			}
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentException("Invalid model.");
				this.model = value;
			}
		}

		public string Manufacturer
		{
			get
			{
				return this.manufacturer;
			}
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentException("Invalid manufacturer.");
				this.manufacturer = value;
			}
		}

		public double Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		public string Owner
		{
			get
			{
				return this.owner;
			}
			set
			{
				this.owner = value;
			}
		}

		public Battery BatteryCharacteristics
		{
			get
			{
				return this.batteryCharacteristics;
			}
			set
			{
				this.batteryCharacteristics = value;
			}
		}

		public Display DisplayCharacterisctics
		{
			get
			{
				return this.displayCharacterisctics;
			}
			set
			{
				this.displayCharacterisctics = value;
			}
		}

		public List<Call> CallHistory
		{
			get;
			private set;
		}

		#endregion

		#region Public Methods
		public void DisplayProperties()
		{
			Console.WriteLine("GMS Characteristics:");
			Console.WriteLine(this.ToString());
		}
		public override string ToString()
		{
			StringBuilder displayedString = new StringBuilder();
			displayedString.Append("Model: ");
			displayedString.AppendLine(model);
			displayedString.Append("Manufacturer: ");
			displayedString.AppendLine(manufacturer);
			if (price > 0)
			{
				displayedString.Append("Price: ");
				displayedString.AppendLine(price.ToString());
			}
			if (owner != null)
			{
				displayedString.Append("Owner: ");
				displayedString.AppendLine(owner);
			}
			if (batteryCharacteristics != null)
			{
				displayedString.Append("Battery characteristics: ");
				displayedString.AppendLine(batteryCharacteristics.ToString());
			}
			if (displayCharacterisctics != null)
			{
				displayedString.Append("Display characteristics: ");
				displayedString.AppendLine(displayCharacterisctics.ToString());
			}
			return displayedString.ToString();
		}

		public void AddCall(Call call)
		{
			CallHistory.Add(call);
		}
		public void DeleteCall(Call call)
		{
			CallHistory.Remove(call);
		}
		public void ClearCallHistory()
		{
			CallHistory.Clear();
		}
		public decimal CalculateTotalPrice(decimal price)
		{
			decimal totalPrice = 0;
			for (int i = 0; i < CallHistory.Count; i++)
			{
				totalPrice += (price * (CallHistory[i].CallDuration / 60));
			}
			return totalPrice;
		}
		public void DisplayCallsHistory()
		{

			if (CallHistory.Count == 0)
				Console.WriteLine("The call history is empty.");
			else
			{
				Console.WriteLine("Call History:");
				for (int i = 0; i < CallHistory.Count; i++)
				{
					Console.Write("{0}. ", i + 1);
					Console.WriteLine(CallHistory[i].ToString());
				}

			}
		}

		#endregion

		#region Private Fields

		private string model;
		private string manufacturer;
		private double price;
		private string owner;
		private Battery batteryCharacteristics;
		private Display displayCharacterisctics;
		private static readonly GSM iPhone4S = new GSM("iPhone4S","Apple");

		#endregion
	}
}