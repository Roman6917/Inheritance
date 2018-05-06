using System;
using Inheritance.Enumeration;

namespace Inheritance.Classes
{
	public class Rectangle : Shape
	{
		private double _length;
		private double _width;

		public double Length
		{
			get => _length;
			set
			{
				if (value < 0.0)
					throw new ArgumentException("Hight can't be negative");

				_length = value;
			}
		}

		private double Width
		{
			get => _width;
			set
			{
				if (value < 0.0)
					throw new ArgumentException("Width can't be negative");

				_width = value;
			}
		}

		public Rectangle(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0.0,
			double length = 0.0, double width = 0.0) : base(fillingColor, contourColor, contourWidth)
		{
			Length = length;
			Width = width;
		}

		public override double Area()
		{
			return Width * Length;
		}

		public override double Perimeter()
		{
			return 2 * (Length + Width);
		}

		public override double Volume()
		{
			return 0;
		}

		public override string ToString()
		{
			return
				$"Rectangle:: {base.ToString()}, Length: {Length:F2}, Width: {Width:F2}, " +
				$"Area: {Area():F2}, Perimeter: {Perimeter():F2}";
		}
	}
}