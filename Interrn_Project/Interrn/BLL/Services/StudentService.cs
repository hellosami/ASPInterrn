using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentDTO> GetStudent()
        {
            var data = DataAccessFactory.StudentDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentProfile, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<StudentDTO>>(data);
            return rt;
        }

        public static StudentDTO Get(int id)
        {
            var data = DataAccessFactory.StudentDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentProfile, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<StudentDTO>(data);
            return rt;
        }
        public static bool Add(StudentDTO student)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, StudentProfile>();
                cfg.CreateMap<StudentProfile, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var dbstudent = mapper.Map<StudentProfile>(student);
            var rt = DataAccessFactory.StudentDataAccess().Add(dbstudent);
            return rt;
        }
    }
}
