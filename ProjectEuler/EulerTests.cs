using System;
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
		public void Problem1_Sum_of_multiples_of_3_or_5_below_1000()
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
		
		public void Problem2_Sum_of_fibonacci_numbers_to_10()
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
		
		public void Problem2_Sum_of_fibonacci_numbers_to_4_million()
		{
			var problem = new Problem2();
			it["the sum of fibonacci evens under 4,000,000 should be 4613732"] = () => problem.FibonacciEvensSum(4000000).should_be(4613732);
		}
	}
}

