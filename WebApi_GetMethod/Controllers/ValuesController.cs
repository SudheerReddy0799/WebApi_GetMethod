using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_GetMethod.Models;


namespace WebApi_GetMethod.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
         EmpEntities1 dbcontext=new EmpEntities1();
        public HttpResponseMessage Get()
        {
            IEnumerable<emp> employees = dbcontext.emps.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, employees);
        }

        // GET api/values/5
        public HttpResponseMessage  Get(int id)
        {
            emp emp=dbcontext.emps.Where(x => x.EmpID == id).FirstOrDefault();
            if(emp!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,emp);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,"Employee id with" + id.ToString()+"Not found");
            }
           
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
