using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentInstructor_University_Assignment;
using System.Data;

namespace StudentInstructor_University_Assignment
{
    public partial class StudentAdvisorDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplayDetails_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            DataSet ds=   s.GetStudentData();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}