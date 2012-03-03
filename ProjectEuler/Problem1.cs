using System;
using System.Linq;
using System.Collections.Generic;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	public class describe_Problem1 : nspec
	{
		void Sum_of_multiples_of_3_or_5_below_10()
		{
			var naturals = FindNaturals(10);    
			it["count of naturals should be 4"] = () => naturals.Count.should_be(4);
			it["the list should contain 3"] = () => naturals.should_contain(3);
			it["the list should contain 5"] = () => naturals.should_contain(5);
			it["the list should contain 6"] = () => naturals.should_contain(6);
			it["the list should contain 9"] = () => naturals.should_contain(9);
			it["the sum of all the naturals should be 23"] = () => FindNaturalsSum(10).should_be(23);
		}
		
		void Sum_of_multiples_of_3_or_5_below_1000()
		{
			var naturals = FindNaturals(1000);
			it["count of naturals should be 466"] = () => naturals.Count.should_be(466);
			it["the list should contain 3"] = () => naturals.should_contain(3);
			it["the list should contain 50"] = () => naturals.should_contain(50);
			it["the list should contain 600"] = () => naturals.should_contain(600);
			it["the list should contain 900"] = () => naturals.should_contain(900);
			it["the sum of all the naturals should be 233168"] = () => FindNaturalsSum(1000).should_be(233168);
		}
		
		public List<int> FindNaturals(int seed)
		{
			var nattys = new List<int>();
			for (int i = 1; i < seed; i++) 
			{
				if (i%3==0||i%5==0)
					nattys.Add(i);
			}
			return nattys;
		}
		
		public int FindNaturalsSum(int seed)
		{
			return FindNaturals(seed).Sum();
		}
	}
}

