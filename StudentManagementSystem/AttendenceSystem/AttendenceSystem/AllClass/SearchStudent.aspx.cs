using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AttendenceSystem.AllClass
{
    public partial class SearchStudent : System.Web.UI.Page
    {
        DataStore ds = new DataStore();
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string query = @" SELECT * FROM [dbo].[Student] WHERE Year=" + TxtYear.Text;
            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
            loaddrid();
        }
        public void loaddrid()
        {
            string query = @" SELECT [SID]
      ,[StudentName]
      ,[Address]
      ,[ContactNo]
      ,[Email]
      ,[Varsity]
      ,[Course]
      ,[Fees]
      ,[FeesPaid]
      ,[Teacher]
      ,[Year]
      ,[StartDate]
      ,[EndDate]
      ,[EntryDate]
      ,[UpdateDate] FROM [dbo].[Student]";

            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string query = @" SELECT * FROM [dbo].[Student] WHERE Fees=" + TxtFees.Text;
            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
            loaddrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string query = @" SELECT * FROM [dbo].[Student] WHERE Teacher like '" + TxtTeacher.Text + " %'";

            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
            loaddrid();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string query = @" SELECT * FROM [dbo].[Student] WHERE StudentName like '" + TxtTeacher.Text + " %'";

            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
            loaddrid();
        }
    }
}