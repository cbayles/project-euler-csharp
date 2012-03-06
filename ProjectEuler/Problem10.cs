using System;
using NSpec;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
	/// Find the sum of all the primes below two million.
	/// </summary>
	public class describe_Problem10 : nspec
	{
		void When_adding_prime_numbers()
		{
			it["Sum of primes less than 10 should be 17"] = () => SumOfPrimesBelow(10).should_be(17);
			it["Sum of primes less than 2,000,000 should be 142913828922"] = () => SumOfPrimesBelow(2000000).should_be(142913828922);
		}
		
		long SumOfPrimesBelow(int max)
		{
			long sum = 2;
			for (int i = 3; i < max; i+=2)
			{
				if (IsPrime(i))
					sum += i;
			}
			return sum;
		}
		
		bool IsPrime(int number)
		{
			if (number == 2) return true;
			if (number < 2 || number % 2 == 0) return false;
			for (int i = 3; i <= Math.Sqrt(number); i+=2)
			{
				if (i == number)
					continue;
				if (number % i == 0)
					return false;
			}
			return true;
		}
	}
}

