using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        private List<string> randomQuotes = new List<string>() { "He gets his angles better than isosceles again", "They convene on him like cheetahs on a gazelle", "It’s like he’s playing a tambourine on his knee", "Nothing less than witchcraft from the sorcerer of football", "Arrives like a witch on a broomstick and produces the hocus pocus in front of goal", "Messi invents passing lanes, he doesn't look for them", "Footballing's bird of paradise is fluffing his feathers beautifully", "He soaks up the defenders just like a paper towel soaks up milk" };
        public IEnumerable<string> getQuotes(long numOfQuotes)
        {
            List<string> list = new List<string>();
            if (numOfQuotes > randomQuotes.Count)
            {
                return randomQuotes;
            }
            else
            {
                for(int i = 0; i<numOfQuotes; i++)
                {
                    list.Add(randomQuotes[i]);
                }
                return list;
            }
            
        }
    }
}
