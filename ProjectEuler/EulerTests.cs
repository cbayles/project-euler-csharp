using System;
using System.Linq;
using NSpec;

namespace ProjectEuler
{
	public class describe_ProjectEuler : nspec
	{
		void Problem1_Sum_of_multiples_of_3_or_5_below_10()
		{
			var problem = new Problem1();
			var naturals = problem.FindNaturals(10);    
			//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
			//Find the sum of all the multiples of 3 or 5 below 1000.
			it["count of naturals should be 4"] = () => naturals.Count.should_be(4);
			it["the list should contain 3"] = () => naturals.should_contain(3);
			it["the list should contain 5"] = () => naturals.should_contain(5);
			it["the list should contain 6"] = () => naturals.should_contain(6);
			it["the list should contain 9"] = () => naturals.should_contain(9);
			it["the sum of all the naturals should be 23"] = () => problem.FindNaturalsSum(10).should_be(23);
		}
		
		void Problem1_Sum_of_multiples_of_3_or_5_below_1000()
		{
			var problem = new Problem1();
			var naturals = problem.FindNaturals(1000);
			//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
			//Find the sum of all the multiples of 3 or 5 below 1000.
			
			it["count of naturals should be 466"] = () => naturals.Count.should_be(466);
			it["the list should contain 3"] = () => naturals.should_contain(3);
			it["the list should contain 50"] = () => naturals.should_contain(50);
			it["the list should contain 600"] = () => naturals.should_contain(600);
			it["the list should contain 900"] = () => naturals.should_contain(900);
			it["the sum of all the naturals should be 233168"] = () => problem.FindNaturalsSum(1000).should_be(233168);
		}
		
		void Problem2_Sum_of_fibonacci_numbers_to_10()
		{
			var problem = new Problem2();
			var numbers = problem.FibonaccisUpTo(10);
			it["count of naturals should be 5"] = () => numbers.Count.should_be(5);
			it["the list should contain 1"] = () => numbers.should_contain(1);
			it["the list should contain 2"] = () => numbers.should_contain(2);
			it["the list should contain 3"] = () => numbers.should_contain(3);
			it["the list should contain 5"] = () => numbers.should_contain(5);
			it["the list should contain 8"] = () => numbers.should_contain(8);
			it["the sum of fibonacci evens under 10 should be 10"] = () => problem.FibonacciEvensSum(10).should_be(10);
		}
		
		void Problem2_Sum_of_fibonacci_numbers_to_4_million()
		{
			var problem = new Problem2();
			it["the sum of fibonacci evens under 4,000,000 should be 4613732"] = () => problem.FibonacciEvensSum(4000000).should_be(4613732);
		}
		
		/// <summary>
		/// The prime factors of 13195 are 5, 7, 13 and 29.
		/// What is the largest prime factor of the number 600851475143 ?
		/// </summary>
		void Problem3_When_finding_prime_factors()
		{
			var problem = new Problem3();
			it["primes of 1 should be empty set"] = () => problem.GetPrimesFor(1).should_be_empty();
			it["primes of 2 should be 2"] = () => problem.GetPrimesFor(2).should_be(2);
			it["primes of 3 should be 3"] = () => problem.GetPrimesFor(3).should_be(3);
			it["primes of 4 should be 2,2"] = () => problem.GetPrimesFor(4).should_be(2,2); 
			it["primes of 5 should be 5"] = () => problem.GetPrimesFor(5).should_be(5);  
			it["primes of 6 should be 2,3"] = () => problem.GetPrimesFor(6).should_be(2,3);  
			it["primes of 7 should be 7"] = () => problem.GetPrimesFor(7).should_be(7); 
			it["primes of 8 should be 2,2,2"] = () => problem.GetPrimesFor(8).should_be(2,2,2); 
			it["primes of 9 should be 3,3"] = () => problem.GetPrimesFor(9).should_be(3,3); 
			it["primes of 10 should be 2,5"] = () => problem.GetPrimesFor(10).should_be(2,5); 
			it["primes of 11 should be 11"] = () => problem.GetPrimesFor(11).should_be(11); 
			it["primes of 12 should be 2,2,3"] = () => problem.GetPrimesFor(12).should_be(2,2,3); 
			it["primes of 13 should be 13"] = () => problem.GetPrimesFor(13).should_be(13);  
			it["primes of 14 should be 2,7"] = () => problem.GetPrimesFor(14).should_be(2,7);  
			it["primes of 15 should be 3,5"] = () => problem.GetPrimesFor(15).should_be(3,5);  
			it["primes of 16 should be 2,2,2,2"] = () => problem.GetPrimesFor(16).should_be(2,2,2,2); 
			it["primes of 17 should be 17"] = () => problem.GetPrimesFor(17).should_be(17);  
			it["primes of 18 should be 2,3,3"] = () => problem.GetPrimesFor(18).should_be(2,3,3);  
			it["primes of 19 should be 19"] = () => problem.GetPrimesFor(19).should_be(19);  
			it["primes of 20 should be 2,2,5"] = () => problem.GetPrimesFor(20).should_be(2,2,5);
			it["primes of 77 should be 7,11"] = () => problem.GetPrimesFor(77).should_be(7,11);  
			it["primes of 13195 should be 5,7,13,29"] = () => problem.GetPrimesFor(13195).should_be(5,7,13,29);
			it["primes of 600851475143 should be 71,839,1471,6857"] = () => problem.GetPrimesFor(600851475143).should_be(71,839,1471,6857); 
			it["max prime of 600851475143 should be 6857"] = () => problem.GetMaxPrime(600851475143).should_be(6857); 
		 }
		
		/// <summary>
		/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
		/// Find the largest palindrome made from the product of two 3-digit numbers.
		/// </summary>
		void Problem4_When_finding_palindromes()
		{
			var problem = new Problem4();
			it["12321 should be one"] = () => problem.IsPalindrome(12321).should_be_true();
			it["9009 should be one"] = () => problem.IsPalindrome(9009).should_be_true();
			it["the largest palindrome from the product of 2 digit numbers should be 9009"] = () => problem.LargestPalindromeFor(2).should_be(9009);
			it["the largest palindrome from the product of 3 digit numbers should be 906609"] = () => problem.LargestPalindromeFor(3).should_be(906609);
		}
	}
}

