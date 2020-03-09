using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab.Demo.EF.WebApi.Controllers
{
    public class RegionController : ApiController
    {
        RegionLogic logic = new RegionLogic();


        // GET: api/Region/
        public List<Region> GetAllRegion()
        {
            var regions = logic.GetAll();

            return regions;
        }

        // GET: api/Region/5
        public Region GetRegion(int id)
        {
            var region = logic.GetOne(id);

            return region;
        }

        // POST: api/Region
        public Region PostRegion(Region region)
        {
            logic.Add(region);

            return (region);
        }

        // PUT: api/Region/
        public Region Put(Region region)
        {
            logic.Update(region);
            return (region);
        }

        // DELETE: api/Region/1
        public Region Delete(int id)
        {

            var regionDelete = logic.GetOne(id);

                logic.Delete(regionDelete);

                return (regionDelete);
            
        }

    }
}
