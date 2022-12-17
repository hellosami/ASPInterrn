using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace Interrn.Controllers
{
    public class PostController : ApiController
    {

        [Route("api/post")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = PostService.GetPost();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/post/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = PostService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/post/add")]
        public HttpResponseMessage Add(PostDTO grp)
        {
            
            var data = PostService.Add(grp);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/post/update")]
        [HttpPost]
        public HttpResponseMessage Update(PostDTO post)
        {
            bool response = PostService.Update(post);
            if (response)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Updated", data = post });

            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/post/delete")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            bool response = PostService.Delete(id);
            if (response)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Deleted", data = id });

            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
