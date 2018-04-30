using System.Collections.Generic;
using Inheritance.Classes;
using System;

namespace Inheritance
{
	public class Task
	{
		public double SumOfShapesArea(List<Shape> shapes)
		{
			double sum = 0;
			foreach (var shape in shapes)
			{
				sum += shape.Area();
			}

			return sum;
		}
		
		public double SumOfShapesPerimeter(List<Shape> shapes)
		{
			double sum = 0;
			foreach (var shape in shapes)
			{
				sum += shape.Perimeter();
			}

			return sum;
		}
		
		public List<Shape> Shapes()
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
		
		public void PrintShapes(List<Shape> shapes)
		{
			Console.WriteLine("Your Shapes: ");
			foreach (var shape in shapes)
			{
				Console.Out.WriteLine(shape.ToString());
			}
		}

		public void DoTask()
		{
			List<Shape> shapes = Shapes();
			PrintShapes(shapes);

			Console.WriteLine($"Total area sum of the shapes: {SumOfShapesArea(shapes)}");
			Console.WriteLine($"Total perimeter sum of the shapes: {SumOfShapesPerimeter(shapes)}");
		}
	}
}