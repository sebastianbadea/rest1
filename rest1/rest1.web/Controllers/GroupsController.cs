using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace rest1.web.Controllers
{
    public class GroupsController : ApiController
    {
        // GET: api/Groups
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new List<string> { "group1", "group2" });
            }
            catch (Exception)
            {
                return InternalServerError();
            }
            
        }

        // GET: api/Groups/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok("group1");
            }
            catch (Exception)
            {
                return InternalServerError();
            }
            
        }

        // POST: api/Groups
        //[HttpPost]
        public IHttpActionResult Post([FromBody]string value)
        {
            return Created(Request.RequestUri + "/2", value);
        }

        //[HttpPatch]
        public IHttpActionResult Patch(int id, [FromBody]string value)
        {
            return Ok(value);
        }

        // PUT: api/Groups/5
        //[HttpPut]
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok(value);
        }

        // DELETE: api/Groups/5
        public void Delete(int id)
        {
        }
    }
}
