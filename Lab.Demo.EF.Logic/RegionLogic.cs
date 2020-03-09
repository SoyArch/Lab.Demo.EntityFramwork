using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Demo.EF.Logic
{
    public class RegionLogic : LogicBase, ILogic<Region>
    {
        public List<Region> GetAll()
        {
            return context.Regions.ToList();
        }

        public Region GetOne(int id)
        {
            return context.Regions.Find(id);
        }

        public List<Region> Add(Region entity) {

            context.Regions.Add(entity);
            context.SaveChanges();

            return GetAll();

        }

        public List<Region> Delete(Region entity) {

            context.Regions.Remove(entity);
            context.SaveChanges();

            return GetAll();

        }

        public Region Update(Region entity)
        {

        var reg = context.Regions.Find(entity.RegionID);

            reg.RegionDescription = entity.RegionDescription;

            context.SaveChanges();

            return GetOne(entity.RegionID);
        }
    }
}
