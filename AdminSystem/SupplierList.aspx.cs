using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
                DisplaySuppliers();
            
        }
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "PhoneNo";
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;

        if(lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to Edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}