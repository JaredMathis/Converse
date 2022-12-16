namespace Converse.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            var word = "apple";
            var l = new Learner(word);
            Assert.AreEqual(l.Learn(), Learner.AskDefinitionFor(word));
        }
        [TestMethod]
        public void TestMethod1()
        {
            var word = "apple";
            var l = new Learner(word);
            Assert.AreEqual(l.Learn(), Learner.AskDefinitionFor(word));
            return l;
        }
    }
}