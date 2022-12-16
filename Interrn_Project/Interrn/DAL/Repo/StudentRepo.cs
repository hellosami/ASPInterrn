using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class StudentRepo : IRepo<StudentProfile, int, bool>
    {
        InterrnEntities db;
        internal StudentRepo()
        {
            db = new InterrnEntities();
        }
        public bool Add(StudentProfile obj)
        {
            db.StudentProfiles.Add(obj);
           return db.SaveChanges()> 0;
            
        }

        public bool Delete(int id)
        {
            db.StudentProfiles.Remove(db.StudentProfiles.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<StudentProfile> Get()
        {
            return db.StudentProfiles.ToList();
        }

        public StudentProfile Get(int id)
        {
            return db.StudentProfiles.Find(id);
        }

        public bool Update(StudentProfile obj)
        {
            var ext = db.StudentProfiles.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
