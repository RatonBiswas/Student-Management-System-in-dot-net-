using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendenceSystem.AllClass
{
    public partial class Student : System.Web.UI.Page
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
        protected void txtinsert_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Student]
           ([SID]
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
           ,[UpdateDate])
     VALUES
           ('"+txtsid.Text + "','" + txtSname.Text + "','" +txtaddress.Text + "','" + txtContactNo.Text + "','" + TextEmail.Text + "','" + txtVarsity.Text + "','" + TxtCourse.Text + "','" + TextFees.Text + "','" + TextFeesPaid.Text + "','" + TxtTeacher.Text + "','" + TxtYear.Text + "','" + TxtStartDate.Text + "','" + TextEndDate.Text + "','" + TextEntryDate.Text + "','" + TexUpdateDate.Text + "')";

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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label ID = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            //TextBox txtTeacherid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
            TextBox studentname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox address = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox ConNo = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
            TextBox Email = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox5");
            TextBox varsity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox6");
            TextBox Course = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox7");
            TextBox Fees = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox8");
            TextBox Feespaid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox9");
            TextBox teacher = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox10");
            TextBox year = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox11");

            string query = @"UPDATE [dbo].[Student]
   SET [StudentName] = '" + studentname.Text + "',[Address] = '"+address.Text + "',[ContactNo] = '"+ConNo.Text + "',[Email] = '"+Email.Text + "',[Varsity] = '"+varsity.Text + "',[Course] = '"+Course.Text + "',[Fees] = '"+Fees.Text + "',[FeesPaid] = '"+Feespaid.Text + "',[Teacher] = '"+teacher.Text + "',[Year] = '"+year.Text + "' WHERE SID=" + ID.Text;
            if (ds.Executequery(query) == 1)
            {
                GridView1.EditIndex = -1;
                loaddrid();
            }
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

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            loaddrid();
        }
    }
}