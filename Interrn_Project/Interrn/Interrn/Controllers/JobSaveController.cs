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
    public class JobSaveController : ApiController
    {
        [Route("api/savejob")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = JobSaveService.GetJobSave();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/savejob/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = JobSaveService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/savejob/add")]
        public HttpResponseMessage Add(JobSaveDTO grp)
        {

            var data = JobSaveService.Add(grp);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
