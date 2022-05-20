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
}