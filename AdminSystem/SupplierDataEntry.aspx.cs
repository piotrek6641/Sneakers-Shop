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

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        string SupplierEmail = txtSupplierEmail.Text;
        string Address = txtAddress.Text;
        string StockAmount = txtStockAmount.Text;
        string PhoneNo = txtPhoneNo.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string Error = "";
        Error = AnSupplier.Valid(SupplierEmail, Address, StockAmount, PhoneNo, DeliveryDate);
        if (Error == "")
        {

            AnSupplier.SupplierEmail = SupplierEmail;
            AnSupplier.Address = Address;
            AnSupplier.StockAmount = Convert.ToInt32(StockAmount);
            AnSupplier.PhoneNo = PhoneNo;
            AnSupplier.DeliveryDate = Convert.ToDateTime(DeliveryDate);

            Session["AnSupplier"] = AnSupplier;
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}