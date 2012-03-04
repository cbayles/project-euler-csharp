using System;
using NSpec;

namespace ProjectEuler
{
	/// <summary>
	/// Find the greatest product of five consecutive digits in the 1000-digit number.
	/// </summary>
	public class describe_Problem8 : nspec
	{
		private const string OneThousandDigitNumber = @"7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
		
		void When_finding_the_product_of_digits()
		{
			it["The first digit in the 1000 digits should be 7"] = () => OneThousandDigitNumber.Substring(0,1).should_be("7");
			it["the first five digits should be 7x3x1x6x7=882"] = () => ProductOfNextFive(0).should_be(882);
			it["the last five digits should be 6x3x4x5x0=0"] = () => ProductOfNextFive(995).should_be(0);
			it["the 2nd-to-last five digits should be 9x6x3x4x5=3240"] = () => ProductOfNextFive(994).should_be(3240);
			it["the greatest product of five digits should be 40824"] = () => GreatestProductOfFiveDigits().should_be(40824);
		}
		
		long GreatestProductOfFiveDigits()
		{
			long greatestProduct = 0;
			for (int i = 0; i < OneThousandDigitNumber.Length-1; i++)
			{
				var product = ProductOfNextFive(i);
				if (product > greatestProduct)
					greatestProduct = product;
			}
			return greatestProduct;
		}
		
		long ProductOfNextFive(int index)
		{
			if (index + 4 > OneThousandDigitNumber.Length-1) return -1;
			int d1 = Convert.ToInt16(OneThousandDigitNumber.Substring(index+0,1));
			int d2 = Convert.ToInt16(OneThousandDigitNumber.Substring(index+1,1));
			int d3 = Convert.ToInt16(OneThousandDigitNumber.Substring(index+2,1));
			int d4 = Convert.ToInt16(OneThousandDigitNumber.Substring(index+3,1));
			int d5 = Convert.ToInt16(OneThousandDigitNumber.Substring(index+4,1));
			return d1*d2*d3*d4*d5;
		}
	}
}

