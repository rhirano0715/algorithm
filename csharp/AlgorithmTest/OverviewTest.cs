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
            public void GetFirstIfTakesArrayWithOneOrMoreElementsThenReturnsTheFirstElement()
            {
                var o = new Overview();
                Assert.That(
                    o.GetFirst(new int[] { 1, 2 }),
                    Is.EqualTo(1)
                );
            }
            [Test]
            public void GetFirstIfTakesEmptyArrayThenReturnsNull()
            {
                var o = new Overview();
                var actual = Assert.Throws<ArgumentException>(
                    () => o.GetFirst(new int[] { })
                );
                Assert.That(actual.Message, Is.EqualTo("items is Empty"));
            }
        }
    }
}
