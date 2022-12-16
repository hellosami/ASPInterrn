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
    public class CompanyController : ApiController
    {

        [Route("api/company")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CompanyService.GetCompany();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Company/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = CompanyService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Company/add")]
        public HttpResponseMessage Add(CompanyDTO grp)
        {
            var data = CompanyService.Add(grp);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
