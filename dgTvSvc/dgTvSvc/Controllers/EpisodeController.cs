using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using dgTvSvc.data;
using dgTvSvc.Models;


namespace dgTvSvc.Controllers
{
    public class EpisodeController : ApiController
    {
        // GET: api/Episode
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<Episode> Get()
        {
            var r = new EpisodeRepository();
            return r.GetMockEpisodes();

            //return new string[] { "value1", "value2" };
        }

        // GET: api/Episode/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Episode
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Episode/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Episode/5
        public void Delete(int id)
        {
        }
    }
}
