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
    }
}
