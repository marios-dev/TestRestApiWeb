using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestRestApiWeb.Models;

namespace TestRestApiWeb.Controllers
{
    public class StudentDataController : ApiController
    {
        // GET: api/StudentData
        public List <StudentDemoData> Get()
        {
            StudentDataList sdList = new StudentDataList();
            return sdList.studentDemoDatas;
        }

        // GET: api/StudentData/5
        public StudentDemoData Get(int id)
        {  
            StudentDemoData sdReturn=null;
            StudentDataList sdList = new StudentDataList();
            foreach (StudentDemoData sd in sdList.studentDemoDatas)
            {
                if (sd.Rollnum == id)
                {
                    sdReturn = sd;
                    break;
                }
            }
            return sdReturn;
        }

        // POST: api/StudentData
        public void Post([FromBody]StudentDemoData value)
        {
        }

        // PUT: api/StudentData/5
        public void Put(int id, [FromBody]StudentDemoData value)
        {
            //update the records 
        }

        // DELETE: api/StudentData/5
        public void Delete(int id)
        {
            //logic to delete the record from list/database table
        }
    }
}
