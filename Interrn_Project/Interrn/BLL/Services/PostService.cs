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
    public class PostService
    {
        public static List<PostDTO> GetPost()
        {
            var data = DataAccessFactory.PostDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<PostDTO>>(data);
            return rt;
        }

        public static PostDTO Get(int id)
        {
            var data = DataAccessFactory.PostDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<PostDTO>(data);
            return rt;
        }
        public static bool Add(PostDTO post)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PostDTO, Post>();
                cfg.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(config);
            var dbpost = mapper.Map<Post>(post);
            var rt = DataAccessFactory.PostDataAccess().Add(dbpost);
            return rt;
        }
    }
}
