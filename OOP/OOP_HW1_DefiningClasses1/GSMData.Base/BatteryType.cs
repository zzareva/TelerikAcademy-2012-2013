using System;
using System.Linq;
using System.ComponentModel;

namespace GSMData.Base
{
	public enum BatteryType
	{
		[Description("Li-Ion")] LiIon, NiMH, NiCd, Other
	}
}
