using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendenceSystem.AllClass
{
    public partial class Course : System.Web.UI.Page
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

        protected void txtinsert_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Course]
           ([CID]
           ,[CourseName]
           ,[CourseFees]
           ,[Duration])
     VALUES
           ('" + txtCid.Text + "','" + txtCname.Text + "','" + txtcourseFees.Text + "','" + txtDuration.Text + "')";

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
            string query = @"DELETE FROM [dbo].[Course]
      WHERE CID=" + ID.Text;
            if (ds.Executequery(query) == 1)
            {
                loaddrid();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label ID = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            //TextBox txtCourseid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
            TextBox txtCoursename = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox txtCourseFees = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox txtDuration = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
            string query = @"UPDATE [dbo].[Course]
   SET [CourseName] = '" + txtCoursename.Text + "',[CourseFees] = '" + txtCourseFees.Text + "',[Duration] = '" + txtDuration.Text + "' WHERE CID=" + ID.Text;
            if (ds.Executequery(query) == 1)
            {
                GridView1.EditIndex = -1;
                loaddrid();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            loaddrid();
        }
    }
}