using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Monitoring.Attributes;
using WebApi.Monitoring.Domain.Enums;

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
        [APIMonitoring(APIAction.API_Get)]
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpDelete("{id}")]
        [APIMonitoring(APIAction.API_Delete)]
        public void Delete(int id)
        {
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
