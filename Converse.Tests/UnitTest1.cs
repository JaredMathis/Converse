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
        }

        [TestMethod]
        public void TestMethod1()
        {
            var l = new Learner(startWord);
            Assert.AreEqual(l.Learn(), Learner.AskDefinitionFor(startWord));
        }
    }
}