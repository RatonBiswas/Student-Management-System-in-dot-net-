using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendenceSystem.AllClass
{
    public partial class Teacher : System.Web.UI.Page
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
            string query = @"SELECT [TID]
      ,[TeacherName]
      ,[Qualification]
      ,[Subject]
  FROM [dbo].[Teacher]";
            GridView1.DataSource = ds.GetData(query);
            GridView1.DataBind();
        }

        protected void txtinsert_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Teacher]
           ([TID]
           ,[TeacherName]
           ,[Qualification]
           ,[Subject])
     VALUES
           ('" + txttid.Text+ "','" + txttname.Text + "','" + txtqualification.Text + "','" + txtsubject.Text + "')";

            if (ds.Executequery(query) == 1)
            {
                loaddrid();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            loaddrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            loaddrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label ID = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM [dbo].[Teacher]
      WHERE TID=" + ID.Text;
            if (ds.Executequery(query) == 1)
            {
                loaddrid();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            loaddrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label ID = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            //TextBox txtTeacherid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
            TextBox txtTeachername = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox txtqualification = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox txtSubject = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
            string query = @"UPDATE [dbo].[Teacher]
   SET [TeacherName] = '" + txtTeachername.Text + "',[Qualification] = '" + txtqualification.Text + "',[Subject] = '" + txtSubject.Text + "' WHERE TID=" + ID.Text;
            if (ds.Executequery(query) == 1)
            {
                GridView1.EditIndex = -1;
                loaddrid();
            }
        }
    }
}