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
            return $"What is {word}?";
        }
    }
}