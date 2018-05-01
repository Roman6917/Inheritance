using System.Collections.Generic;
using Inheritance.Classes;
using System;
using System.Linq;

namespace Inheritance
{
	public class Task
	{
		private static double SumOfShapesArea(IEnumerable<Shape> shapes)
		{
			return shapes.Sum(shape => shape.Area());
		}

		private static double SumOfShapesPerimeter(IEnumerable<Shape> shapes)
		{
			return shapes.Sum(shape => shape.Perimeter());
		}

		private static List<Shape> Shapes()
		{
			var shapes = new List<Shape>
			{
				new Circle(Color.Blue, Color.Purple, 2.5, 7),
				new Rectangle(Color.Brown, Color.Pink, 4.5, 5, 5),
				new Cylinder(Color.Red, Color.Yellow, 1.5, 7, 3),
				new Parallelepiped(Color.Orange, Color.Green, 1.5, 6, 5, 8)
			};
			return shapes;
		}

		private static void PrintShapes(IEnumerable<Shape> shapes)
		{
			Console.WriteLine("Your Shapes: ");
			shapes.ToList().ForEach(shape =>
				Console.Out.WriteLine($"{{{shape}}}")
			);
		}

		public static void DoTask()
		{
			var shapes = Shapes();
			PrintShapes(shapes);

			Console.WriteLine($"\nTotal area sum of the shapes: {SumOfShapesArea(shapes):F2}");
			Console.WriteLine($"\nTotal perimeter sum of the shapes: {SumOfShapesPerimeter(shapes):F2}");
		}
	}
}