using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class AppliedJobRepo : IRepo<AppliedJob, int, bool>
    {
        InterrnEntities db;
        public AppliedJobRepo()
        {
            db = new InterrnEntities();
        }
        public bool Add(AppliedJob obj)
        {
            db.AppliedJobs.Add(obj);
            return db.SaveChanges()> 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppliedJob> Get()
        {
            return db.AppliedJobs.ToList();
        }

        public AppliedJob Get(int id)
        {
            return db.AppliedJobs.Find(id);
        }

        public bool Update(AppliedJob obj)
        {
            var ext = db.AppliedJobs.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
