using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }


    }
    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        LstStaffList.DataSource = Staff.StaffList;
        LstStaffList.DataValueField = "StaffID";
        LstStaffList.DataTextField = "StaffLogin";
        LstStaffList.DataBind();
    }

    protected void LstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }


  

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (LstStaffList.SelectedIndex!=-1)
        {
            StaffID = Convert.ToInt32(LstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if(LstStaffList.SelectedIndex!=-1)
        {
            StaffID = Convert.ToInt32(LstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void Apply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByLogin(LoginFilter.Text);
        LstStaffList.DataSource = Staff.StaffList;
        LstStaffList.DataValueField = "StaffID";
        LstStaffList.DataValueField = "StaffLogin";
        LstStaffList.DataBind();
    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        LoginFilter.Text = "";
        LstStaffList.DataSource = Staff.StaffList;
        LstStaffList.DataValueField = "StaffID";
        LstStaffList.DataValueField = "StaffLogin";
        LstStaffList.DataBind();
    }
}