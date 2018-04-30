using System;

namespace Inheritance.Classes
{
	public class Rectangle : Shape
	{
		private double _height;
		private double _width;

		protected double Hight
		{
			get => _height;
			private set
			{
				if (value < 0.0)
					throw new ArgumentException("Hight can't be negative");

				_height = value;
			}
		}

		public double Width
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
			double height = 0.0, double width = 0.0) : base(fillingColor, contourColor, contourWidth)
		{
			_height = height;
			_width = width;
		}

		public override double Area()
		{
			return Width * Hight;
		}

		public override double Perimeter()
		{
			return 2 * (Hight + Width);
		}

		public override double Volume()
		{
			return 0;
		}

		public override string ToString()
		{
			return
				$"Rectangle: \n{base.ToString()}, {nameof(Hight)}: {Hight}, " +
				$"{nameof(Width)}: {Width}, Area: {Area()}, Perimeter: {Perimeter()}";
		}
	}
}