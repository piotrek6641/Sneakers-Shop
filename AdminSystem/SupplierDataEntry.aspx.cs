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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        int SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = AnSupplier.Find(SupplierID);
        if (Found == true)
        {
            txtAddress.Text = AnSupplier.Address;
            txtDeliveryDate.Text = AnSupplier.DeliveryDate.ToString();
            txtPhoneNo.Text = AnSupplier.PhoneNo;
            txtStockAmount.Text = AnSupplier.StockAmount.ToString();
            txtSupplierEmail.Text = AnSupplier.SupplierEmail;
        }

    }
}