namespace Converse.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private string apple;
        private Learner sut;
        private string fruit;
        private AskDefinition askDefinition;

        [TestInitialize]
        public void TestInitialize()
        {
            apple = "apple";
            fruit = "fruit";
            askDefinition = new AskDefinition();
            sut = new Learner(askDefinition, apple);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestMethod1();

            sut.Learn(askDefinition.For(apple), fruit);

            Assert.IsTrue(sut.Quiz(Learner.Implies(apple, fruit)));
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(sut.Question(), askDefinition.For(apple));
        }
    }
}