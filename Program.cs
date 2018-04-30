using System;
using Inheritance.Classes;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Task task = new Task();
				task.DoTask();

				var parallepiped = new Parallelepiped(Color.Black, Color.Blue, 1.5, 2, 2, 2);
				Console.Out.WriteLine($"Volume of parallepiped: {parallepiped.Volume()}");

				var cylinder = new Cylinder(Color.Black, Color.Blue, 2.5, 2, 3);
				Console.Out.WriteLine($"Volume of cylinder: {cylinder.Volume()}");
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}