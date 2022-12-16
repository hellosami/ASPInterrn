using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<StudentProfile, int, bool> StudentDataAccess()
        {
            return new StudentRepo();
        }

        public static IRepo<CompanyProfile, int, bool> CompanyDataAccess()
        {
            return new CompanyRepo();
        }

        public static IRepo<Post, int, bool> PostDataAccess()
        {
            return new PostRepo();
        }

        public static IRepo<JobSave, int, bool> JobSaveDataAccess()
        {
            return new JobSaveRepo();
        }
        public static IRepo<AppliedJob, int, bool> AppliedJobDataAccess()
        {
            return new AppliedJobRepo();
        }
    }
}
