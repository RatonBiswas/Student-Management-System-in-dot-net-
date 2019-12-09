using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendenceSystem.AllClass
{
    public partial class StudentManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserCourseInfo.aspx");
        }

        protected void Admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AllClass/Login.aspx");
        }
    }
}