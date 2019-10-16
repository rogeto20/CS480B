using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    public class RandomControllerTests
    {
        RandomController controller;

        [SetUp]
        public void Setup()
        {
            controller = new RandomController();
            controller.path = Constants.LocalFilePath;
        }
        [Test]
        public void GetRandomQuote()
        {
            Quotes quote = controller.Get();
            Assert.IsTrue(quote is Quotes);
        }
    }
}