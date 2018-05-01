using System;
using System.Globalization;

namespace Inheritance.Classes
{
	public abstract class Shape
	{
		private Color FillingColor { get; }
		private Color ContourColor { get; }

		private double _contourWidth;

		private double ContourWidth
		{
			get => _contourWidth;
			set
			{
				if (value < 0.0)
				{
					throw new ArgumentException("Width can't be negative");
				}

				_contourWidth = value;
			}
		}

		protected Shape(Color fillingColor = Color.White, Color contourColor = Color.Black, double contourWidth = 0.0)
		{
			ContourWidth = contourWidth;
			FillingColor = fillingColor;
			ContourColor = contourColor;
		}

		public override string ToString()
		{
			return $"FillingColor: {FillingColor}, ContourColor: {ContourColor}, ContourWidth: {ContourWidth}";
		}

		public abstract double Area();
		public abstract double Perimeter();
		public abstract double Volume();
	}
}