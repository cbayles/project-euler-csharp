using System;
using System.Text;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
	/// Find the largest palindrome made from the product of two 3-digit numbers.
	/// </summary>
	public class describe_Problem4 : nspec
	{
		void When_finding_palindromes()
		{
			it["12321 should be one"] = () => IsPalindrome(12321).should_be_true();
			it["9009 should be one"] = () => IsPalindrome(9009).should_be_true();
			it["the largest palindrome from the product of 2 digit numbers should be 9009"] = () => LargestPalindromeFor(2).should_be(9009);
			it["the largest palindrome from the product of 3 digit numbers should be 906609"] = () => LargestPalindromeFor(3).should_be(906609);
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

