using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Configuration;
using MongoDBAPI.Services;

namespace MongoDBAPI.Controllers
{
    public class PeopleController : ApiController
    {
        // GET api/people
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/people/545a4r4555dfasd
        public string Get(string _id)
        {
            var connection = WebConfigurationManager.ConnectionStrings["MongoDB"].ToString();
            MongoDataService dataService = new MongoDataService(connection);

            return dataService.findOne("test", "people",String.Format("{{_id: ObjectId(\"{0}\") }}", _id));
        }

        // POST api/people
        public void Post([FromBody]string value)
        {
        }

        // PUT api/people/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/people/5
        public void Delete(int id)
        {
        }
    }
}
