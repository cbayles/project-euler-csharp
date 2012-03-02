using System;
using System.Text;

namespace ProjectEuler
{
	/// <summary>
	/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
	/// Find the largest palindrome made from the product of two 3-digit numbers.
	/// </summary>
	public class Problem4
	{
		public Problem4()
		{
		}
		
		public long LargestPalindromeFor(int digits)
		{
			long maxNum = Convert.ToInt64("9".PadRight(digits, '9'));
			long minNum = Convert.ToInt64("1".PadRight(digits, '0'));
			long largest = -1;
			
			for (long i = minNum; i <= maxNum; i++)
			{
				for (long n = i; n <= maxNum; n++)
				{
					var product = n*i;
					if (product > largest && IsPalindrome(product))
						largest = product;
				}
			}
			return largest;
		}
		
		public bool IsPalindrome(long number)
		{
			char[] original = number.ToString().ToCharArray();
			char[] reversed = number.ToString().ToCharArray();
			Array.Reverse(reversed);
			for (int i = 0; i < original.Length; i++)
			{
				if (original[i] != reversed[i])
					return false;
			}
			return true;
		}
	}
}

