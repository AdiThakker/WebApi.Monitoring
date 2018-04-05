using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Monitoring.Monitoring.Attributes;
using WebApi.Monitoring.Monitoring.Enums;

namespace WebApi.Monitoring.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("Items")]
        [APIMonitoring(APIActions.API_Get)]
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpDelete("{id}")]
        [APIMonitoring(APIActions.API_Delete)]
        public void Delete(int id)
        {
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
