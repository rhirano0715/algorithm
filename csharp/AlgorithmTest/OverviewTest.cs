namespace Algorithm;

public class OverviewTest
{
    [SetUp]
    public void Setup()
    {
    }

    public class BigO { 
        public class O1 
        {
            [Test]
            public void GetFirst()
            {
                var o = new Overview();
                var input = new int[] { 1, 2 };
                Assert.That(o.GetFirst(input), Is.EqualTo(1));
            }
        }
    }
}
