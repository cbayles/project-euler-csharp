using System;
using System.Collections.Generic;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	/// </summary>
	public class describe_Problem5 : nspec
	{
		void When_finding_the_smallest_number()
		{
			it["divisible by 1-2 should be 2"] = () => SmallestDivisibleByAllUpTo(2).should_be(2);
			it["divisible by 1-3 should be 6"] = () => SmallestDivisibleByAllUpTo(3).should_be(6);
			it["4 factorial should be 4x3x2x1=24"] = () => Factorial(4).should_be(24);
			it["5 factorial should be 5x4x3x2x1=120"] = () => Factorial(5).should_be(120);
			it["divisible by 1-4 should be 12"] = () => SmallestDivisibleByAllUpTo(4).should_be(12);
			it["divisible by 1-5 should be 60"] = () => SmallestDivisibleByAllUpTo(5).should_be(60);
			it["divisible by 1-10 should be 2520"] = () => SmallestDivisibleByAllUpTo(10).should_be(2520);
			it["divisible by 1-20 should be 232792560"] = () => SmallestDivisibleByAllUpTo(20).should_be(232792560);
		}
		
		long SmallestDivisibleByAllUpTo(int maxDivisor)
		{
			long answer = Factorial(maxDivisor);
			
			for (int divisor = maxDivisor; divisor > 0; divisor--)
			{
				var possibleAnswer = answer / divisor;
				if (IsDivisibleByAllUpTo (possibleAnswer, maxDivisor) && possibleAnswer < answer)
					answer = possibleAnswer;
			}
			
			return answer;
		}
		
		long Factorial(int maxNum)
		{
			long product = 1;
			
			for (int i = maxNum; i > 0; i--)
			{
				product *= i;
			}
			
			return product;
		}
		
		bool IsDivisibleByAllUpTo(long dividend, int maxDivisor)
		{
			for (int divisor = maxDivisor; divisor > 0; divisor--)
			{
				if (dividend % divisor != 0) 
				{
					return false;
				}
			}
			return true;
		}
	}
}

