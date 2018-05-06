using System;
using Inheritance.Enumeration;

namespace Inheritance.Classes
{
	public class Parallelepiped : Rectangle
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

		public Parallelepiped(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0,
			double length = 0, double width = 0, double height = 0.0) : base(fillingColor, contourColor,
			contourWidth, length, width)
		{
			Height = height;
		}

		public override double Volume()
		{
			return Area() * Height;
		}

		public override string ToString()
		{
			return $"Parallelepiped:: [{base.ToString()}], Hight: {Height:F2}, Volume: {Volume():F2}";
		}
	}
}