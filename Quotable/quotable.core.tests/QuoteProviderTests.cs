using NUnit.Framework;
using quotable.core;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Test class for the quote provider in the quotable.core
    /// </summary>
    public class QuoteProviderTests
    {
        SimpleRandomQuoteProvider QuoteProvider;

        /// <summary>
        /// This is the setup method run before every quote provider test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            QuoteProvider = new SimpleRandomQuoteProvider(Constants.LocalFilePath);
        }

        /// <summary>
        /// tests getting of valid quotes from valid ids
        /// Asserts that the quotes gotten are equal to the id passed
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(9)]
        public void getQuotesById_ValidId(int id)
        {
            Quotes quote = QuoteProvider.getQuotesbyID(id);
            Assert.AreEqual(id,quote.ID);
        }

        /// <summary>
        /// tests getting of valid quotes from invalid ids
        /// Asserts that the quotes gotten are equal to -1 which is what is returned from invalid ids
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase(-10)]
        [TestCase(123)]
        [TestCase(2324)]
        public void getQuotesById_InvalidId(int id)
        {
            Quotes quote = QuoteProvider.getQuotesbyID(id);
            Assert.AreEqual(-1, quote.ID);
        }

        /// <summary>
        /// Tests that the method get quotes returns a list of quotes
        /// </summary>
        [Test]
        public void getQuotes_returnsListofQuotes()
        {
            Assert.IsTrue(QuoteProvider.getQuotes() is IEnumerable<Quotes>);
        }
    }
}