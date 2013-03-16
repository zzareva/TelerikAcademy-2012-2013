using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D_UI
{
	class PointsUI
	{
		static void Main()
		{
			//Creating points
			Point3D firstPoint = new Point3D(1, 2, 3);
			Point3D secondPoint = new Point3D(4, 5, 6);
			//printing points
			Console.WriteLine("The first point is:{0}", firstPoint.ToString());
			Console.WriteLine("The second point is:{0}", secondPoint.ToString());

			double distance = PointDistanceCalculation.CalculateDistance(firstPoint, secondPoint);
			Console.WriteLine("The distance between the two points is: {0}", distance);

			//Creating new path with the two points
			Path3D thePath = new Path3D();
			thePath.AddPoint(firstPoint);
			thePath.AddPoint(secondPoint);

			//Saving path to file
			PathStorage.SavePath(thePath, "exampleOutput.csv");

			//reading path from file
			Path3D pathFromFile = PathStorage.LoadPath("examplePointsInput.csv");
			Console.WriteLine("The points from the path file are: {0}", pathFromFile);

		}
	}
}
