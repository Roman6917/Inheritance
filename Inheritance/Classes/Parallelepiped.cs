using System;

namespace Inheritance.Classes
{
	public class Parallelepiped : Rectangle
	{
		private double _hight;

		private double Hight
		{
			get => _hight;
			set
			{
				if (value < 0.0)
					throw new ArgumentException("Width can't be negative");

				_hight = value;
			}
		}

		public Parallelepiped(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0,
			double length = 0, double width = 0, double hight = 0.0) : base(fillingColor, contourColor,
			contourWidth, length, width)
		{
			Hight = hight;
		}

		public override double Volume()
		{
			return Area() * Hight;
		}

		public override string ToString()
		{
			return $"Parallelepiped:: [{base.ToString()}], Hight: {Hight:F2}, Volume: {Volume():F2}";
		}
	}
}