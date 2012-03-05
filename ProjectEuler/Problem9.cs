using System;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// A Pythagorean triplet is a set of three natural numbers, a  b  c, for which a^2 + b^2 = c^2
	/// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
	/// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
	/// Find the product a*b*c.
	/// </summary>
	public class describe_Problem9 : nspec
	{
		void When_finding_Pythagorean_triplets()
		{
			it["The triplet 3,4,5 should be pythagorean"] = () => IsPythagoreanTriplet(3,4,5).should_be_true();
			it["The triplet 3,4,6 should NOT be pythagorean"] = () => IsPythagoreanTriplet(3,4,6).should_be_false();
			it["a, b, c for sum 25 should be 3,4,5"] = () => FindABCForSum(12).should_be(new Tuple<int, int, int>(3,4,5));
			it["a, b, c for sum 1000 should be 200, 375, 425"] = () => FindABCForSum(1000).should_be(new Tuple<int, int, int>(200, 375, 425));
			it["product of a, b, c for sum 1000 should be 31,875,000"] = () => ProductOfTripletForSum(1000).should_be(31875000);
		}
		
		long ProductOfTripletForSum(int sum)
		{
			var triplet = FindABCForSum(sum);
			return triplet.Item1 * triplet.Item2 * triplet.Item3;
		}
		
		Tuple<int, int, int> FindABCForSum(int sum)
		{
			for (int a = 1; a < sum; a++)
			{
				for (int b = a+1; b < sum; b++)
				{
					for (int c = b+1; c < sum; c++)
					{
						if (a+b+c == sum)
							if (IsPythagoreanTriplet(a,b,c))
								return new Tuple<int, int, int>(a, b, c);
					}
				}
			}
			return new Tuple<int, int, int>(0,0,0);
		}
		
		bool IsPythagoreanTriplet(int a, int b, int c)
		{
			if ((a*a) + (b*b) == (c*c))
				return true;
			return false;
		}
	}
}

