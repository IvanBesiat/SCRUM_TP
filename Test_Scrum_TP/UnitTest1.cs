namespace Test_Scrum_TP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsFizz()
        {
            int value = 3;

            FizzBuzz testFB = new FizzBuzz(value);

            Assert.AreEqual(testFB.NbrTest(value), "FIZZ");
        }
        [TestMethod]
        public void TestIsBUzz()
        {
            int value = 5;

            FizzBuzz testFB = new FizzBuzz(value);

            Assert.AreEqual(testFB.NbrTest(value), "BUZZ");
        }
        [TestMethod]
        public void TestIsFizzBuzz()
        {
            int value = 15;

            FizzBuzz testFB = new FizzBuzz(value);

            Assert.AreEqual(testFB.NbrTest(value), "FIZZBUZZ");
        }
        [TestMethod]
        public void TestNoFizzNoBuzz()
        {
            int value = 2;

            FizzBuzz testFB = new FizzBuzz(value);

            Assert.AreEqual(testFB.NbrTest(value), "PERDU");
        }
    }
}