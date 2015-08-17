using B2BSearch.Search.BookSearch.ThirdPartyHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2BSearch.Controllers
{
    public class BooksController : ApiController
    {
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/<controller>/5
        public string GET([FromUri]string query)
        {
            SearchForBooks searchForBooks = new SearchForBooks();
            return (searchForBooks.Search(query).ToString());

        }

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}