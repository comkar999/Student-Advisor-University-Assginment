using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentInstructor_University_Assignment
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentCourse { get; set; }
        public int AdvisorId { get; set; }
         
       public DataSet  GetStudentData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sc = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("spStudentDetails", sc);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;



                }
             
    }
}