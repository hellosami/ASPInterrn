using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class PostRepo : IRepo<Post, int, bool>
    {
        InterrnEntities db;
        public PostRepo()
        {
            db = new InterrnEntities();
        }
        public bool Add(Post obj)
        {
            try
            {
                db.Posts.Add(obj);
                return db.SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        public bool Delete(int id)
        {
            db.Posts.Add(db.Posts.Find(id));
            return db.SaveChanges() > 0;    
        }

        public List<Post> Get()
        {
            return db.Posts.ToList();
        }

        public Post Get(int id)
        {
            
            return db.Posts.Find(id);
        }

        public bool Update(Post obj)
        {
            var ext = db.Posts.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
