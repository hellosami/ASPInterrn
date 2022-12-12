using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Interrn.Controllers
{
    
    public class StudentController : ApiController
    {
        
        
            [Route("api/students")]
            [HttpGet]
            public HttpResponseMessage Get()
            {
                var data = StudentService.GetStudent();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            
            [Route("api/student/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
            {
                var data = StudentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            [HttpPost]
            [Route("api/student/add")]
            public HttpResponseMessage Add(StudentDTO grp)
            {
                var data = StudentService.Add(grp);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
        }
    }

