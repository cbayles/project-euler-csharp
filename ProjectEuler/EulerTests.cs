using System;
using NUnit.Framework;

namespace ProjectEuler
{
	[TestFixture]
	public class EulerTests
	{
		[Test]
		public void Problem1_Given_10()
		{
			var problem = new Problem1();
			var naturals = problem.FindNaturals(10);
			//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
			//Find the sum of all the multiples of 3 or 5 below 1000.
			Assert.That(naturals, Contains.Item(3));
			Assert.That(naturals, Contains.Item(5));
			Assert.That(naturals, Contains.Item(6));
			Assert.That(naturals, Contains.Item(9));
			Assert.That(problem.FindNaturalsSum(10), Is.EqualTo(23));
		}
		[Test]
		public void Problem1_Given_1000()
		{
			var problem = new Problem1();
			var naturals = problem.FindNaturals(1000);
			//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
			//Find the sum of all the multiples of 3 or 5 below 1000.
			Assert.That(naturals, Contains.Item(3));
			Assert.That(naturals, Contains.Item(5));
			Assert.That(naturals, Contains.Item(6));
			Assert.That(naturals, Contains.Item(9));
			Assert.That(naturals, Contains.Item(30));
			Assert.That(naturals, Contains.Item(50));
			Assert.That(naturals, Contains.Item(60));
			Assert.That(naturals, Contains.Item(90));
			Assert.That(naturals, Contains.Item(300));
			Assert.That(naturals, Contains.Item(500));
			Assert.That(naturals, Contains.Item(600));
			Assert.That(naturals, Contains.Item(900));
			Assert.That(problem.FindNaturalsSum(1000), Is.EqualTo(2300000));
		}
	}
}

