using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    ///Interface
    public interface RandomQuoteProvider
    {
        IEnumerable<Quotes> getQuotes(long numOfQuotes);
    }
}
