namespace Converse.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private string apple;
        private Learner sut;
        private string fruit;

        [TestInitialize]
        public void TestInitialize()
        {
            apple = "apple";
            fruit = "fruit";
            sut = new Learner(apple);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestMethod1();

            sut.Learn(Learner.AskDefinitionFor(apple), fruit);

            Assert.IsTrue(sut.Quiz(Learner.Implies(apple, fruit)));
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(sut.Question(), Learner.AskDefinitionFor(apple));
        }
    }
}