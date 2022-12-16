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
    public class CompanyService
    {
        public static List<CompanyDTO> GetCompany()
        {
            var data = DataAccessFactory.CompanyDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CompanyProfile, CompanyDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<CompanyDTO>>(data);
            return rt;
        }

        public static CompanyDTO Get(int id)
        {
            var data = DataAccessFactory.CompanyDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CompanyProfile, CompanyDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<CompanyDTO>(data);
            return rt;
        }
        public static bool Add(CompanyDTO company)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CompanyDTO, CompanyProfile>();
                cfg.CreateMap<CompanyProfile, CompanyDTO>();
            });
            var mapper = new Mapper(config);
            var dbcompany = mapper.Map<CompanyProfile>(company);
            var rt = DataAccessFactory.CompanyDataAccess().Add(dbcompany);
            return rt;
        }
    }
}

