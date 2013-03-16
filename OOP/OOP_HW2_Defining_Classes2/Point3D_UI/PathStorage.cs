using System;
using System.Linq;
using System.IO;
using Point3D_UI;

public static class PathStorage
{
	public static void SavePath(Path3D path, string fileName)
	{
		StreamWriter writer = new StreamWriter("..\\..\\" + fileName);
		using (writer)
		{
			writer.Write(path.ToString());
		}
	}
	public static Path3D LoadPath(string fileName)
	{
		StreamReader reader = new StreamReader("..\\..\\" + fileName);
		var path = new Path3D();
		using (reader)
		{
			string[] strPath = reader.ReadToEnd().Split(';');
			foreach (string point in strPath)
			{
				path.AddPoint(PointParser.ParsePoint(point));
			}
		}
		return path;
	}

}
