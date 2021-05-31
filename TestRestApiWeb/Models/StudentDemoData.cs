using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRestApiWeb.Models
{
    public class StudentDemoData
    {
        public int Rollnum { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }
    public class StudentDataList
    {
        public List<StudentDemoData> studentDemoDatas { get; set; }
        public StudentDataList()
        {
            studentDemoDatas = new List<StudentDemoData>();
            StudentDemoData sd = new StudentDemoData();
            sd.Rollnum = 1001;
            sd.Name = "Marios";
            sd.Course = "MCA";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.Rollnum = 1002;
            sd.Name = "Parios";
            sd.Course = "MBA";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.Rollnum = 1003;
            sd.Name = "Larios";
            sd.Course = "MDA";
            studentDemoDatas.Add(sd);
        }
    }
}