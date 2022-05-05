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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        AnSupplier.SupplierEmail = txtSupplierEmail.Text;
        Session["AnSupplier"] = AnSupplier;
        Response.Redirect("SupplierViewer.aspx");
    }
}