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
    public class AppliedJobService
    {
        public static List<AppliedJobDTO> GetAppliedJob()
        {
            var data = DataAccessFactory.AppliedJobDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AppliedJob, AppliedJobDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<AppliedJobDTO>>(data);
            return rt;
        }

        public static AppliedJobDTO Get(int id)
        {
            var data = DataAccessFactory.AppliedJobDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AppliedJob, AppliedJobDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<AppliedJobDTO>(data);
            return rt;
        }
        public static bool Add(AppliedJobDTO data)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AppliedJobDTO, AppliedJob>();
                cfg.CreateMap<AppliedJob, AppliedJobDTO>();
            });
            var mapper = new Mapper(config);
            var dbdata = mapper.Map<AppliedJob>(data);
            var rt = DataAccessFactory.AppliedJobDataAccess().Add(dbdata);
            return rt;
        }
    }
}
