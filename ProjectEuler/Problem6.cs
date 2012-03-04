using System;
using NSpec;
 
namespace ProjectEuler
{
	/// <summary>
	/// The sum of the squares of the first ten natural numbers is: 1^2 + 2^2 + ... + 10^2 = 385
	/// The square of the sum of the first ten natural numbers is: (1 + 2 + ... + 10)^2 = 552 = 3025
	/// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.
	/// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
	/// </summary>
	public class describe_Problem6 : nspec
	{
		void Finding_the_difference_between_sum_of_squares_and_square_of_the_sum()
		{
			it["sum of squares up to 10 should be 385"] = () => SumOfSquaresUpTo(10).should_be(385);
			it["square of sum up to 10 should be 3025"] = () => SquareOfSumUpTo(10).should_be(3025);
			it["difference of sum and square up to 10 should be 2640"] = () => DifferenceOfSumAndSquareUpTo(10).should_be(2640);
			it["difference of sum and square up to 100 should be 25164150"] = () => DifferenceOfSumAndSquareUpTo(100).should_be(25164150);
		}
		
		long DifferenceOfSumAndSquareUpTo(int maxNum)
		{
			return SquareOfSumUpTo(maxNum) - SumOfSquaresUpTo(maxNum);
		}
		
		long SumOfSquaresUpTo(int maxNum)
		{
			long result = 0;
			for (int i = 1; i <= maxNum; i++)
			{
				result += (i*i);
			}
			return result;
		}
		
		long SquareOfSumUpTo(int maxNum)
		{
			long result = 0;
			for (int i = 1; i <= maxNum; i++)
			{
				result += i;
			}
			return result*result;
		}
	}
}

