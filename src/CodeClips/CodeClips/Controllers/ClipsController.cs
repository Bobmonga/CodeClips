using CodeClips.Entities.Clips;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodeClips.Controllers
{
    [Route("api/[controller]")]
    public class ClipsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            Clip clip = new Clip
            {
                Title = "REDIS Repo",
                Content = "Here is some code",
                Tags = new List<string>
                {
                    "C#",
                    "REDIS",
                    "Repository"
                }
            };

            return new OkObjectResult(clip);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
