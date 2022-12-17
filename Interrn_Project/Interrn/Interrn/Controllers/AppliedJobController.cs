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
    public class AppliedJobController : ApiController
    {
        [Route("api/appliedjobs")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AppliedJobService.GetAppliedJob();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/appliedjobs/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AppliedJobService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/appliedjobs/add")]
        public HttpResponseMessage Add(AppliedJobDTO apjob)
        {

            var data = AppliedJobService.Add(apjob);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        /*  [Route("api/appliedjobs/update")]
          [HttpPost]
          public HttpResponseMessage Update(AppliedJobDTO apjob)
          {
              bool response = AppliedJobService.Update(apjob);
              if (response)
              {
                  return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Updated", data = apjob });

              }
              return Request.CreateResponse(HttpStatusCode.InternalServerError);
          }

          [Route("api/appliedjobs/delete")]
          [HttpPost]
          public HttpResponseMessage Delete(int id)
          {
              bool response = AppliedJobService.Delete(id);
              if (response)
              {
                  return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Deleted", data = id });

              }
              return Request.CreateResponse(HttpStatusCode.InternalServerError);
          }
        */
    }
}
