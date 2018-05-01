﻿using System;
using Inheritance.Classes;

namespace Inheritance
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			Task.Do();

			Shape figure = new Parallelepiped(Color.Black, Color.Blue, 1.5, 2, 2, 2);
			Console.Out.WriteLine(string.Format("Volume of parallepiped: {0:F2}", figure.Volume()));

			figure = new Cylinder(Color.Black, Color.Blue, 2.5, 2, 3);
			Console.Out.WriteLine(string.Format("Volume of cylinder: {0:F2}", figure.Volume()));
		}
	}
}