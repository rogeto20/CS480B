using NUnit.Framework;
using quotable.core;

namespace Tests
{
    public class QuoteProviderTests
    {
        SimpleRandomQuoteProvider QuoteProvider;

        [SetUp]
        public void Setup()
        {
            QuoteProvider = new SimpleRandomQuoteProvider(@"../../../../quotable.core/quotes.txt");
        }

        [Test]
        public void getQuotesById_ValidId()
        {
            int id = 1;
            Quotes quote = QuoteProvider.getQuotesbyID(id);
            Assert.AreEqual(id,quote.ID);
        }
    }
}