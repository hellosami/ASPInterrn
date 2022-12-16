using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class CompanyRepo : IRepo<CompanyProfile, int, bool>
    {
        InterrnEntities db;
        internal CompanyRepo()
        {
            db = new InterrnEntities();
        }
        public bool Add(CompanyProfile obj)
        {
            db.CompanyProfiles.Add(obj);
           return db.SaveChanges() >0;
           
        }

        public bool Delete(int id)
        {
            db.CompanyProfiles.Remove(db.CompanyProfiles.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<CompanyProfile> Get()
        {
            return db.CompanyProfiles.ToList();
        }

        public CompanyProfile Get(int id)
        {
            return db.CompanyProfiles.Find(id);
        }

        public bool Update(CompanyProfile obj)
        {
            var ext = db.CompanyProfiles.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
