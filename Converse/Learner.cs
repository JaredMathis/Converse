namespace Converse
{
    public class Learner
    {
        private string startWord;
        private AskDefinition askDefinition;

        public Learner(AskDefinition ad, string startWord)
        {
            this.startWord = startWord;
            this.askDefinition = ad;
        }

        public string Question()
        {
            return askDefinition.For(startWord);
        }

        public void Learn(string question, string answer)
        {

        }

        public static string Implies(string a, string b)
        {
            return $"a is b";
        }

        public bool Quiz(string v)
        {
            throw new NotImplementedException();
        }
    }
}