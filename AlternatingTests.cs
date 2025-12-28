using FluentAssertions;

namespace cassidoo_2025_12_22
{
    [TestClass]
    public sealed class AlternatingTests
    {
        [TestMethod]
        public void TestExamplesFromEmail()
        {
			AlternatingDetector.IsAlternating([]).Should().BeTrue();
			AlternatingDetector.IsAlternating([1]).Should().BeTrue();
			AlternatingDetector.IsAlternating([1, 1]).Should().BeTrue();
			AlternatingDetector.IsAlternating([1, 2, 1]).Should().BeTrue();
			AlternatingDetector.IsAlternating([10, 5, 10, 5, 10]).Should().BeTrue();
			AlternatingDetector.IsAlternating([2, 2, 3, 3]).Should().BeFalse();
			AlternatingDetector.IsAlternating([5, 4, 3, 5, 4, 3]).Should().BeFalse();
		}

		[TestMethod]
		public void TestNegativeNumbers()
		{
			AlternatingDetector.IsAlternating([-1]).Should().BeTrue();
			AlternatingDetector.IsAlternating([-1, 0]).Should().BeTrue();
			AlternatingDetector.IsAlternating([-2, 2, -2]).Should().BeTrue();
			AlternatingDetector.IsAlternating([-1, 2, 1, 2]).Should().BeFalse();
		}
    }
}
