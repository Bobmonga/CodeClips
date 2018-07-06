using CodeClips.Data.Repos;
using CodeClips.Entities.Clips;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CodeClips.Controllers
{
    [Route("api/[controller]")]
    public class ClipsController : Controller
    {
        IRepo _repository;

        public ClipsController(IRepo repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_repository.GetClip(Guid.NewGuid()));
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
