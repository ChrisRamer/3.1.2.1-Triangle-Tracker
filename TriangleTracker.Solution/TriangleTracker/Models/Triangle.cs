using System;

namespace TriangleTracker
{
	public class Triangle
	{
		static void Main()
		{
			Console.WriteLine("Please give me a number for one side of a triangle!");
			int side1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Please give me a number for the second side of the triangle!");
			int side2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Please give me a number for the final side of the triangle!");
			int side3 = int.Parse(Console.ReadLine());

			Console.WriteLine("I will now tell you the type of the triangle...");
			Console.WriteLine(GetTriangleType(side1, side2, side3));
		}

		public static string GetTriangleType(int side1, int side2, int side3)
		{
			if (side1 == side2 && side2 == side3)
			{
				return "Equilateral";
			}
			else if ((side1 + side2) < side3 || (side1 + side3) < side2 || (side2 + side3) < side1)
			{
				return "NaT: Not a Triangle";
			}
			else if (side1 == side2 || side2 == side3 || side1 == side3)
			{
				return "Isosceles";
			}
			else if (side1 != side2 && side2 != side3 && side2 != side3)
			{
				return "Scalene";
			}

			return "NaT: Not a Triangle";
		}
	}
}