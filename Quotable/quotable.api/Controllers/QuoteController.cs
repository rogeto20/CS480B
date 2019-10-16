using System.Collections.Generic;
using quotable.core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
        public SimpleRandomQuoteProvider randomQuoteProvider;
        public string path;

        public QuoteController()
        {
            path = Constants.RemoteFilePath;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Quotes> Get()
        {
            randomQuoteProvider = new SimpleRandomQuoteProvider(path);
            return randomQuoteProvider.getQuotes();
        }

        // GET api/<controller>/5
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
