using System;
using System.Linq;
using System.Text;

public struct Point3D
{

	public int X { get; set; }
	public int Y { get; set; }
	public int Z { get; set; }

	public Point3D(int x, int y, int z) : this()
	{
		this.X = x;
		this.Y = y;
		this.Z = z;
	}

	private static readonly Point3D coordinateSystemStart = new Point3D(0, 0, 0);

	public static Point3D CoordinateSystemStart
	{
		get
		{
			return coordinateSystemStart;
		}
	}

	public override string ToString()
	{
		StringBuilder strPrint = new StringBuilder();
		strPrint.Append('{');
		strPrint.Append(this.X);
		strPrint.Append(',');
		strPrint.Append(this.Y);
		strPrint.Append(',');
		strPrint.Append(this.Z);
		strPrint.Append('}');
		return strPrint.ToString();
	}
}
