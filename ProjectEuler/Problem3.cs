using System;
using System.Linq;
using System.Collections.Generic;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	public class describe_Problem3 : nspec
	{
		void When_finding_prime_factors()
		{
			it["primes of 1 should be empty set"] = () => GetPrimesFor(1).should_be_empty();
			it["primes of 2 should be 2"] = () => GetPrimesFor(2).should_be(2);
			it["primes of 3 should be 3"] = () => GetPrimesFor(3).should_be(3);
			it["primes of 4 should be 2,2"] = () => GetPrimesFor(4).should_be(2,2); 
			it["primes of 5 should be 5"] = () => GetPrimesFor(5).should_be(5);  
			it["primes of 6 should be 2,3"] = () => GetPrimesFor(6).should_be(2,3);  
			it["primes of 7 should be 7"] = () => GetPrimesFor(7).should_be(7); 
			it["primes of 8 should be 2,2,2"] = () => GetPrimesFor(8).should_be(2,2,2); 
			it["primes of 9 should be 3,3"] = () => GetPrimesFor(9).should_be(3,3); 
			it["primes of 10 should be 2,5"] = () => GetPrimesFor(10).should_be(2,5); 
			it["primes of 11 should be 11"] = () => GetPrimesFor(11).should_be(11); 
			it["primes of 12 should be 2,2,3"] = () => GetPrimesFor(12).should_be(2,2,3); 
			it["primes of 13 should be 13"] = () => GetPrimesFor(13).should_be(13);  
			it["primes of 14 should be 2,7"] = () => GetPrimesFor(14).should_be(2,7);  
			it["primes of 15 should be 3,5"] = () => GetPrimesFor(15).should_be(3,5);  
			it["primes of 16 should be 2,2,2,2"] = () => GetPrimesFor(16).should_be(2,2,2,2); 
			it["primes of 17 should be 17"] = () => GetPrimesFor(17).should_be(17);  
			it["primes of 18 should be 2,3,3"] = () => GetPrimesFor(18).should_be(2,3,3);  
			it["primes of 19 should be 19"] = () => GetPrimesFor(19).should_be(19);  
			it["primes of 20 should be 2,2,5"] = () => GetPrimesFor(20).should_be(2,2,5);
			it["primes of 77 should be 7,11"] = () => GetPrimesFor(77).should_be(7,11);  
			it["primes of 13195 should be 5,7,13,29"] = () => GetPrimesFor(13195).should_be(5,7,13,29);
			it["primes of 600851475143 should be 71,839,1471,6857"] = () => GetPrimesFor(600851475143).should_be(71,839,1471,6857); 
			it["max prime of 600851475143 should be 6857"] = () => GetMaxPrime(600851475143).should_be(6857); 
		 }

		public long GetMaxPrime(long seed)
		{
			var start = DateTime.Now;
			var primes = GetPrimesFor(seed);
			var end = DateTime.Now;
			Console.WriteLine("Finished in {0} milliseconds", end.Subtract(start).TotalMilliseconds);
			return primes.Max();
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

