using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D_UI
{
	public class Path3D
	{
		private readonly List<Point3D> points = new List<Point3D>();

		public IEnumerable<Point3D> Points
		{
			get
			{
				return points;
			}
		}
		public void AddPoint(Point3D newPoint)
		{
			points.Add(newPoint);
		}
		public override string ToString()
		{
			return String.Join(", ", Points);
		}
	}
}
