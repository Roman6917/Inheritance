using System;
using System.Collections.Generic;
using Inheritance.Classes;
using Xunit;

namespace Inheritance.Test.Classes
{
	public class RectangleTest
	{
		[Theory]
		[MemberData(nameof(RectangleTestData.Perimeter), MemberType = typeof(RectangleTestData))]
		public void CheckPerimeter(int expected, Rectangle r)
		{
			Assert.Equal(expected, r.Perimeter());
		}

		[Theory]
		[MemberData(nameof(RectangleTestData.Throws), MemberType = typeof(RectangleTestData))]
		public void CheckThrows(double length, double width)
		{
			Assert.Throws<ArgumentException>(() => new Rectangle(length:length, width:width));
		}

		private class RectangleTestData
		{
			public static IEnumerable<object[]> Throws => new List<object[]>
			{
				new object[] {-1, 1},
				new object[] {1, -1},
				new object[] {0, -1},
				new object[] {-1, -1},
			};
			public static IEnumerable<object[]> Perimeter => new List<object[]>
			{
				new object[] {20, new Rectangle(length: 5, width: 5)},
				new object[] {4, new Rectangle(length: 1, width: 1)},
				new object[] {12, new Rectangle(length: 2.5, width: 3.5)},
				new object[] {7, new Rectangle(length: 0, width: 3.5)},
				new object[] {4, new Rectangle(length: 2, width: 0)},
				new object[] {0, new Rectangle()},
			};
		};
	}
}