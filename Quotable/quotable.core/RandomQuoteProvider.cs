using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Interface class
    /// </summary>
    public interface RandomQuoteProvider
    {
        IEnumerable<Quotes> getQuotes(long numOfQuotes);
    }
}
