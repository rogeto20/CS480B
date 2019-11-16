using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    /// <summary>
    /// This is the test class for the APIs 'randomQuote' resource
    /// </summary>
    public class RandomControllerTests
    {
        RandomController controller;

        /// <summary>
        /// This is the setup function to run before every test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            controller = new RandomController
            {
                path = Constants.LocalFilePath
            };
        }

        /// <summary>
        /// test for the random quotes
        /// </summary>
        [Test]
        public void GetRandomQuote()
        {
            //var quote = controller.Get();
            Assert.IsTrue(controller.Get() is ActionResult<Quotes>);
        }
    }
}