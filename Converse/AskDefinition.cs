using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converse
{
    public class AskDefinition
    {
        public string For(string word)
        {
            return $"what is {word}?";
        }
    }
}
