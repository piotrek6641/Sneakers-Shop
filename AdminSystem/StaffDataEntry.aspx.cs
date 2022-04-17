using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 staffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffID = Convert.ToInt32(Session["StaffID"]);
        if(IsPostBack == false)
        {
            if (staffID != -1)
            {
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(staffID);
        TextStaffID.Text = StaffBook.ThisStaff.StaffID.ToString();
        TextStaffLogin.Text = StaffBook.ThisStaff.StaffLogin.ToString();
        TextStaffEmail.Text = StaffBook.ThisStaff.StaffEmail.ToString();
        TextStaffPassword.Text = StaffBook.ThisStaff.StaffPassword.ToString();
        

    }

    protected void StaffOK_Click(object sender, EventArgs e)
    {
        
        clsStaff AStaff = new clsStaff();
        String StaffEmail = TextStaffEmail.Text;
        String StaffPassword = TextStaffPassword.Text;
        String StaffID = TextStaffID.Text;
        String StaffDateCreated = TextDateCreated.Text;
        String isAdmin = "true";
        String StaffLogin = TextStaffLogin.Text;
        String error = "";
        
        error = AStaff.Valid(StaffID, StaffLogin, StaffPassword, StaffEmail, isAdmin, StaffDateCreated);
        if (error=="")
        {
            
            AStaff.StaffEmail = StaffEmail;
            AStaff.StaffPassword = StaffPassword;
            AStaff.StaffID = Convert.ToInt32(StaffID);
            AStaff.DateCreated = Convert.ToDateTime(StaffDateCreated);
            AStaff.StaffLogin = StaffLogin;
            AStaff.StaffIsAdmin = Convert.ToBoolean(isAdmin);
            clsStaffCollection StaffList = new clsStaffCollection();
            if(staffID==-1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(staffID);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }
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
            TextStaffLogin.Text = AStaff.StaffLogin;



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