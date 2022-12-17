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
        [Route("api/company/update")]
        [HttpPost]
        public HttpResponseMessage Update(CompanyDTO company)
        {
            bool response = CompanyService.Update(company);
            if (response)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Updated", data = company });

            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/company/delete")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            bool response = CompanyService.Delete(id);
            if (response)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Deleted", data = id });

            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
