using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendenceSystem.AllClass
{
    
    public partial class AddFees : System.Web.UI.Page
    {
        DataStore ds = new DataStore();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = @" SELECT * FROM [dbo].[Student] WHERE SID=" + StudentID.Text;
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

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            loaddrid();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            loaddrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label ID = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM [dbo].[Student]
      WHERE SID=" + ID.Text;
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
            TextBox Fees = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox8");
            TextBox Feespaid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox9");
            string query = @"UPDATE [dbo].[Student]
   SET [Fees] = '" + Fees.Text + "',[FeesPaid] = '" + Feespaid.Text + "'  WHERE SID=" + ID.Text;
            if (ds.Executequery(query) == 1)
            {
                GridView1.EditIndex = -1;
                loaddrid();
            }
        }
    }
}