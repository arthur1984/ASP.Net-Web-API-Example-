using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPI.Models;
using RestAPI.Servises;

namespace RestAPI.Controllers
{
    [RoutePrefix("api/company")]
    public class CompanyController : ApiController
    {
        [Route("create")]
        [HttpPost]
        public HttpResponseMessage Create(Company company)
        {
            if (ModelState.IsValid)
            {
                CompanyService.Create(company);
                return Request.CreateResponse(HttpStatusCode.OK, company);
            }
            else {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
