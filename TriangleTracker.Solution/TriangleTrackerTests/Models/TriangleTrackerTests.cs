using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTrackerTests
{
	[TestClass]
	public class TriangleTrackerTests
	{
		[TestMethod]
		public void GetTriangleType_Equilateral_String()
		{
			int side1 = 2; int side2 = 2; int side3 = 2;
			string result = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(result, "Equilateral");
		}

		[TestMethod]
		public void GetTriangleType_Isosceles1_String()
		{
			int side1 = 2; int side2 = 2; int side3 = 3;
			string reuslt = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(reuslt, "Isosceles");
		}

		[TestMethod]
		public void GetTriangleType_Isosceles2_String()
		{
			int side1 = 3; int side2 = 2; int side3 = 2;
			string reuslt = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(reuslt, "Isosceles");
		}

		[TestMethod]
		public void GetTriangleType_Isosceles3_String()
		{
			int side1 = 2; int side2 = 3; int side3 = 2;
			string reuslt = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(reuslt, "Isosceles");
		}

		[TestMethod]
		public void GetTriangleType_Scalene_String()
		{
			int side1 = 2; int side2 = 3; int side3 = 5;
			string result = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(result, "Scalene");
		}

		[TestMethod]
		public void GetTriangleType_NotATriangle1_String()
		{
			int side1 = 2; int side2 = 3; int side3 = 50;
			string result = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(result, "NaT: Not a Triangle");
		}

		[TestMethod]
		public void GetTriangleType_NotATriangle2_String()
		{
			int side1 = 50; int side2 = 3; int side3 = 2;
			string result = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(result, "NaT: Not a Triangle");
		}

		[TestMethod]
		public void GetTriangleType_NotATriangle3_String()
		{
			int side1 = 3; int side2 = 50; int side3 = 2;
			string result = Triangle.GetTriangleType(side1, side2, side3);
			Assert.AreEqual(result, "NaT: Not a Triangle");
		}
	}
}