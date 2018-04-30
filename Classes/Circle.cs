using System;

namespace Inheritance.Classes
{
	public class Circle : Shape
	{
		private double _radius;

		private double Radius
		{
			get => _radius;
			set
			{
				if (value < 0.0)
					throw new ArgumentException("Radius can't be negative");

				_radius = value;
			}
		}

		public Circle(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0.0,
			double radius = 0.0) : base(fillingColor, contourColor, contourWidth)
		{
			_radius = radius;
		}

		public override double Area()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}

		public override double Perimeter()
		{
			return 2 * Math.PI * Radius;
		}

		public override double Volume()
		{
			return 0;
		}

		public override string ToString()
		{
			return $"Circle:\n{base.ToString()}, " +
			       $"{nameof(Radius)}: {Radius}, Area: {Area()}, Perimeter: {Perimeter()}";
		}
	}
}