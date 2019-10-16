using System.Collections.Generic;
using quotable.core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    /// <summary>
    /// Quote Controller resource
    /// </summary>
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
        public SimpleRandomQuoteProvider randomQuoteProvider;
        public string path;

        /// <summary>
        /// Quote controller constructor. Added to facilitate easy changing of the file path for testing and reusability
        /// </summary>
        public QuoteController()
        {
            path = Constants.RemoteFilePath;
        }

        // GET: api/<controller>
        /// <summary>
        /// Get all the quotes from the .txt file in the directory
        /// </summary>
        /// <returns>A list of quote objects</returns>
        [HttpGet]
        public IEnumerable<Quotes> Get()
        {
            randomQuoteProvider = new SimpleRandomQuoteProvider(path);
            return randomQuoteProvider.getQuotes();
        }

        // GET api/<controller>
        /// <summary>
        /// Gets a specific quote from the provided ID
        /// </summary>
        /// <param name="id">The id of the quote being requested</param>
        /// <returns>The ID being requested</returns>
        [HttpGet("{id}")]
        public Quotes Get(int id)
        {
            randomQuoteProvider = new SimpleRandomQuoteProvider(path);
            return randomQuoteProvider.getQuotesbyID(id);
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
