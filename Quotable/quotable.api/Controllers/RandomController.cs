using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    public class RandomController : Controller
    {
        public SimpleRandomQuoteProvider randomQuoteProvider;
        public string path;

        public RandomController()
        {
            path = Constants.RemoteFilePath;
        }
        // GET: api/<controller>
        /// <summary>
        /// Gets a random quote from the .txt directory
        /// </summary>
        /// <returns>A random quote</returns>
        [HttpGet]
        public Quotes Get()
        {
            randomQuoteProvider = new SimpleRandomQuoteProvider(path);
            int numberOfQuotes = randomQuoteProvider.getQuotes().Count();
            Random random = new Random();
            int rand = random.Next(0, numberOfQuotes);

            return randomQuoteProvider.getQuotesbyID(rand);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
