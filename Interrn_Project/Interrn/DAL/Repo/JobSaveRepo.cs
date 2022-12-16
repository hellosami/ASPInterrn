using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class JobSaveRepo : IRepo<JobSave, int, bool>
    {
        InterrnEntities db;
        public  JobSaveRepo()
        {
            db = new InterrnEntities();
        }

        public bool Add(JobSave obj)
        {
            db.JobSaves.Add(obj);
            return db.SaveChanges() >0;
           
        }

        public bool Delete(int id)
        {
            db.JobSaves.Remove(db.JobSaves.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<JobSave> Get()
        {
            return db.JobSaves.ToList();
        }

        public JobSave Get(int id)
        {
            return db.JobSaves.Find(id);
        }

        public bool Update(JobSave obj)
        {
            throw new NotImplementedException();
        }
    }
}
