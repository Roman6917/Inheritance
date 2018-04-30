﻿using System;

namespace Inheritance.Classes
{
	public class Cylinder : Circle
	{
		private double _height;

		public double Height
		{
			get => _height;
			set
			{
				if (value < 0.0)
					throw new ArgumentException("Width can't be negative");

				_height = value;
			}
		}

		public Cylinder(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0,
			double radius = 0, double height = 0.0) : base(fillingColor, contourColor, contourWidth, radius)
		{
			_height = height;
		}

		public override string ToString()
		{
			return
				$"Cylinder based on {base.ToString()}, {nameof(Height)}: {Height}, " +
				$"Area: {Area()}, Perimeter: {Perimeter()}, Volume: {Volume()}";
		}

		public override double Volume()
		{
			return Area() * Height;
		}
	}
}