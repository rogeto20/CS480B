﻿using System.Collections.Generic;
using quotable.core;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using quotable.core.data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    /// <summary>
    /// Quote Controller resource
    /// </summary>
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
       
        private readonly QuoteContext _context;

        /// <summary>
        /// Quote controller constructor. Added to facilitate easy changing of the file path for testing and reusability
        /// </summary>
        public QuoteController(QuoteContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        /// <summary>
        /// Get all the quotes from the .txt file in the directory
        /// </summary>
        /// <returns>A list of quote objects</returns>
        [HttpGet]
        public IEnumerable<Quotes> Get()
        {
            var quote =  from quotes in _context.Quotes
                            select new Quotes()
                            {
                                Quote = quotes.Quote
                            };
            return quote;
        }

        // GET api/<controller>
        /// <summary>
        /// Gets a specific quote from the provided Id
        /// </summary>
        /// <param name="id">The id of the quote being requested</param>
        /// <returns>The Id being requested</returns>
        [HttpGet("{id}")]
        public ActionResult<Quotes> Get(int id)
        {
            var quote = _context.Quotes.SingleOrDefault(d => d.Id == id);

            if (quote == null)
            {
                return NotFound();
            }

            return new Quotes()
            {
                Quote = quote.Quote
            };
        }
    

        /// <summary>
        /// Autogenerated Post method
        /// </summary>
        /// <param name="value"></param>
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Autogenerated put method
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Autogenerated Delete method
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
