using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	public class Problem1
	{
		public Problem1()
		{
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

