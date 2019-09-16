using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    ///Interface
    public interface RandomQuoteProvider
    {
        IEnumerable<string> getQuotes(long numOfQuotes);
    }
}
