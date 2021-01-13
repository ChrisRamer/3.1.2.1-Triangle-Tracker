using System;

namespace TriangleTracker
{
	public class Triangle
	{
		static void Main()
		{
			Console.WriteLine("Please give me a number for one side of a triangle!");
			Console.WriteLine("-------------------------");

			// Get side 1
			int side1 = 0;
			if (int.TryParse(Console.ReadLine(), out int num1))
			{
				if (num1 > 0)
				{
					side1 = num1;
					Console.WriteLine("Please give me a number for the second side of the triangle!");
					Console.WriteLine("-------------------------");
				}
				else
				{
					InvalidNumber();
					return;
				}
			}
			else
			{
				InvalidNumber();
				return;
			}

			// Get side 2
			int side2 = 0;
			if (int.TryParse(Console.ReadLine(), out int num2))
			{
				if (num2 > 0)
				{
					side2 = num2;
					Console.WriteLine("Please give me a number for the final side of the triangle!");
					Console.WriteLine("-------------------------");
				}
				else
				{
					InvalidNumber();
					return;
				}
			}
			else
			{
				InvalidNumber();
				return;
			}

			// Get side 3
			int side3 = 0;
			if (int.TryParse(Console.ReadLine(), out int num3))
			{
				if (num3 > 0)
				{
					side3 = num3;
					Console.WriteLine("-------------------------");
					Console.WriteLine("I will now tell you the type of the triangle...");
					Console.WriteLine("Your triangle is " + GetTriangleType(side1, side2, side3) + "!");
				}
				else
				{
					InvalidNumber();
					return;
				}
			}
			else
			{
				InvalidNumber();
			}
		}

		static void InvalidNumber()
		{
			Console.WriteLine("Please specify a whole number greater than 0!");
			Console.WriteLine("-------------------------");
			Main();
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
			else if (side1 != side2 && side2 != side3 && side1 != side3)
			{
				return "Scalene";
			}

			return "NaT: Not a Triangle";
		}
	}
}