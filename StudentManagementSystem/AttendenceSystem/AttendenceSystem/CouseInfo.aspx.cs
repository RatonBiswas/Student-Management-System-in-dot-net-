using AttendenceSystem.AllClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendenceSystem
{
    public partial class CouseInfo : System.Web.UI.Page
    {
        DataStore ds = new DataStore();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddrid();
            }
        }
        public void loaddrid()
        {
            string query = @"SELECT [CID]
      ,[CourseName]
      ,[CourseFees]
      ,[Duration]
  FROM [dbo].[Course]";
            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
        }

    }
}