using System;
using System.Linq;

namespace Point3D_UI
{
	public static class PointParser
	{
		public static Point3D ParsePoint(string strCoordinates)
		{
			string[] strCoord = strCoordinates.Split(',');
			Point3D newPoint = new Point3D(int.Parse(strCoord[0]),int.Parse(strCoord[1]),int.Parse(strCoord[2]));
			return newPoint;
		}
	}
}
