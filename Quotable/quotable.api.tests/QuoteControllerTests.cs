using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    /// <summary>
    /// Class containing tests for the quote controller in the quoteable.api project
    /// </summary>
    public class QuoteControllerTests
    {
        QuoteController controller;

        [SetUp]
        private void Setup()
        {
            controller = new QuoteController
            {
                path = Constants.LocalFilePath
            };
        }

        /// <summary>
        /// uses the controller to call the get method using valid id's
        /// asserts that the quote gotten has the same id as the id given
        /// </summary>
        /// <param name="id">the quote id being passed into the test</param>
        [Test]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(9)]
        public void GetQuotesById_ValidId(int id)
        {
            var quote = controller.Get(id);
            Assert.AreEqual(id, quote.Value.ID);
        }

        /// <summary>
        /// uses the quote controller to get quotes using invalid ids.
        /// asserts that the quote recieved has an id of -1 as an invalid id is passed into it
        /// </summary>
        /// <param name="id">invalid ids</param>
        [Test]
        [TestCase(-10)]
        [TestCase(123)]
        [TestCase(2324)]
        public void GetQuotesById_InvalidId(int id)
        {
            
            var quote = controller.Get(id);
            Assert.AreEqual(-1, quote.Value.ID);
        }
    }
}