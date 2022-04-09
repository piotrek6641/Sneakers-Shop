using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void StaffOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        String StaffEmail = TextStaffEmail.Text;
        String StaffPassword = TextStaffPassword.Text;
        String StaffID = TextStaffID.Text;
        String StaffDateCreated = TextDateCreated.Text;
        String isAdmin = "true";
        String StaffLogin = "pp";
        String error = "";
        
        error = AStaff.Valid(StaffID, StaffLogin, StaffPassword, StaffEmail, isAdmin, StaffDateCreated);
        if (error=="")
        {
            
            AStaff.StaffEmail = StaffID;
            AStaff.StaffPassword = StaffPassword;
            AStaff.StaffID = Convert.ToInt32(StaffID);
            AStaff.DateCreated = Convert.ToDateTime(StaffDateCreated);
            Session["AStaff"] = AStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblerror1.Text = error;
        }
        
        
    }

    protected void btn_Find_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean found = false;
        StaffID = Convert.ToInt32(TextStaffID.Text);
        found = AStaff.Find(StaffID);
        if (found == true)
        {
            TextStaffEmail.Text = AStaff.StaffEmail;
            TextStaffPassword.Text = AStaff.StaffPassword;
            TextDateCreated.Text = AStaff.DateCreated.ToString();



        }    

    }



    protected void btn_Find_Click1(object sender, EventArgs e)
    {

    }

    protected void TextDateCreated_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextStaffID_TextChanged(object sender, EventArgs e)
    {

    }
}