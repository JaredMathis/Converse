namespace Converse
{
    public class Learner
    {
        private string startWord;

        public Learner(string startWord)
        {
            this.startWord = startWord;
        }

        public string Question()
        {
            return AskDefinitionFor(startWord);
        }

        public static string AskDefinitionFor(string word)
        {
            return $"what is {word}?";
        }

        public void Learn(string question, string answer)
        {
            throw new NotImplementedException();
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