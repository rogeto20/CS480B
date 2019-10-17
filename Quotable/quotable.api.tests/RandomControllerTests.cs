using Microsoft.AspNetCore.Mvc;
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
            //var quote = controller.Get();
            Assert.IsTrue(controller.Get() is ActionResult<Quotes>);
        }
    }
}