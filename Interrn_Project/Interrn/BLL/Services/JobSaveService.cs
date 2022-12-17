using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;

namespace BLL.Services
{
    public class JobSaveService
    {
        public static List<JobSaveDTO> GetJobSave()
        {
            var data = DataAccessFactory.JobSaveDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobSave, JobSaveDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<JobSaveDTO>>(data);
            return rt;
        }

        public static JobSaveDTO Get(int id)
        {
            var data = DataAccessFactory.JobSaveDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobSave, JobSaveDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<JobSaveDTO>(data);
            return rt;
        }
        public static bool Add(JobSaveDTO jobSave)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobSaveDTO, JobSave>();
                cfg.CreateMap<JobSave, JobSaveDTO>();
            });
            var mapper = new Mapper(config);
            var dbjobSave = mapper.Map<JobSave>(jobSave);
            var rt = DataAccessFactory.JobSaveDataAccess().Add(dbjobSave);
            return rt;
        }
        /* public static bool Update(JobSaveDTO obj)
         {
             var config = new MapperConfiguration(cfg => cfg.CreateMap<JobSaveDTO, JobSave>());
             var mapper = new Mapper(config);
             var rtdata = mapper.Map<JobSave>(obj);
             return DataAccessFactory.JobSaveDataAccess().Update(rtdata);
         }

         public static bool Delete(int id)
         {
             return DataAccessFactory.JobSaveDataAccess().Delete(id);
         }*/
    }
}
