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
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCustomersCollection Customers = new clsCustomersCollection();

        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "Customerid";
        lstCustomerList.DataTextField = "Customer_email";
        lstCustomerList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Customerid"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 Customerid;

        if (lstCustomerList.SelectedIndex != -1)
        {
            Customerid = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["Customerid"] = Customerid;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select record to edit from the list";
        }
    }
}



