using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	public class Problem3
	{
		public Problem3()
		{
		}

		public long[] GetPrimes(long seed)
		{
			var start = DateTime.Now;
			var primes = GetPrimesFor(seed);
			var end = DateTime.Now;
			Console.WriteLine("Finished in {0} milliseconds", end.Subtract(start).TotalMilliseconds);
			return primes;
		}
		
		public long[] GetPrimesFor(long seed)
		{
			var primes = new List<long>();
			
			if (seed < 2) return new long[0];
			
			for (long i = 2; i < seed; i++)
			{
				if (seed % i == 0)
				{
					//Console.WriteLine("found prime: " + i);
					primes.Add(i);
					primes.AddRange(GetPrimesFor(seed/i));
					break;
				}
			}
			
			if (primes.Count == 0)
			{
				//Console.WriteLine("found prime: " + seed);
				primes.Add(seed);	
			}
			
			return primes.ToArray();
		}
		
	}
}

