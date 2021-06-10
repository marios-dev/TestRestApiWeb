using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestRestApiWeb.Models
{
    public class StudentDBRep:StudentDBEntities
    {
        public List<StudentData> GetAllStudentsRecord()
        {
            return StudentDatas.ToList();
        }
        public StudentData GetStudentRecord(int ID)
        {
            StudentData sdResult = null;
            List<StudentData> lstStudent = StudentDatas.Where(s => s.StudentID == ID).ToList(); 
            return sdResult;
        }
    }
}