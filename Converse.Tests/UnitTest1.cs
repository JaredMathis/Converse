namespace Converse.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private string startWord;
        private Learner sut;

        [TestInitialize]
        public void TestInitialize()
        {
            startWord = "apple";
            sut = new Learner(startWord);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestMethod1();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(sut.Learn(), Learner.AskDefinitionFor(startWord));
        }
    }
}