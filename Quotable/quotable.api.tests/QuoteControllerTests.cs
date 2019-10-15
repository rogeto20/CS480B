using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    public class QuoteControllerTests
    {
        QuoteController controller;

        [SetUp]
        public void Setup()
        {
            controller = new QuoteController();
        }

        [Test]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(9)]
        public void getQuotesById_ValidId(int id)
        {
            Quotes quote = QuoteProvider.getQuotesbyID(id);
            Assert.AreEqual(id, quote.ID);
        }

        [Test]
        [TestCase(-10)]
        [TestCase(123)]
        [TestCase(2324)]
        public void getQuotesById_InvalidId(int id)
        {
            Quotes quote = QuoteProvider.getQuotesbyID(id);
            Assert.AreEqual(-1, quote.ID);
        }
    }
}