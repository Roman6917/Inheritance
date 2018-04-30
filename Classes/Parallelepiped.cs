using System;

namespace Inheritance.Classes
{
	public class Parallelepiped : Rectangle
	{
		private double _parallelepipedHight;

		public double ParallelepipedHight
		{
			get => _parallelepipedHight;
			set
			{
				if (value < 0.0)
					throw new ArgumentException("Width can't be negative");

				_parallelepipedHight = value;
			}
		}

		public Parallelepiped(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0,
			double height = 0, double width = 0, double parallelepipedHight = 0.0) : base(fillingColor, contourColor,
			contourWidth, height, width)
		{
			_parallelepipedHight = parallelepipedHight;
		}

		public override double Volume()
		{
			return Area() * ParallelepipedHight;
		}

		public override string ToString()
		{
			return
				$"Parallelepiped based on {base.ToString()}, " +
				$"{nameof(ParallelepipedHight)}: {ParallelepipedHight}," +
				$" Area: {Area()}, Perimeter: {Perimeter()}, Volume: {Volume()}";
		}
	}
}