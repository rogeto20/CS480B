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
        /// <summary>
        /// This is the interface method get quotes
        /// </summary>
        /// <param name="numOfQuotes"></param>
        /// <returns></returns>
        IEnumerable<Quotes> getQuotes(long numOfQuotes);
    }
}
