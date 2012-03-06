using System;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
	/// What is the 10,001st prime number?
	/// </summary>
	public class describe_Problem7 : nspec
	{
		void When_finding_prime_numbers()
		{
			it["1 should NOT be a prime"] = () => IsPrime(1).should_be_false();
			it["2 should be a prime"] = () => IsPrime(2).should_be_true();
			it["3 should be a prime"] = () => IsPrime(3).should_be_true();
			it["4 should NOT be a prime"] = () => IsPrime(4).should_be_false();
			it["5 should be a prime"] = () => IsPrime(5).should_be_true();
			it["6 should NOT be a prime"] = () => IsPrime(6).should_be_false();
			it["7 should be a prime"] = () => IsPrime(7).should_be_true();
			it["11 should be a prime"] = () => IsPrime(11).should_be_true();
			it["12 should NOT be a prime"] = () => IsPrime(12).should_be_false();
			it["13 should be a prime"] = () => IsPrime(13).should_be_true();
			it["13 should be the 6th prime"] = () => GetNthPrime(6).should_be(13);
			it["17 should be the 7th prime"] = () => GetNthPrime(7).should_be(17);
			it["104743 should be the 10,001st prime"] = () => GetNthPrime(10001).should_be(104743);
		}
		
		long GetNthPrime(int number)
		{
			int possiblePrime = 0;
			int primeCount = 0;
			do
			{
				possiblePrime++;
				if (IsPrime(possiblePrime))
				{
					primeCount++;
				}
			} while (primeCount < number);
			return possiblePrime;
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

