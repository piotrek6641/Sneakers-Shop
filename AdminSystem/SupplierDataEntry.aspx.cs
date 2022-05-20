using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if(IsPostBack == false)
        {
            if(SupplierID != -1)
            {
                DisplayAddress();
            }
        }

    }

    private void DisplayAddress()
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();

        SupplierBook.ThisSupplier.Find(SupplierID);

        txtSupplierID.Text = SupplierBook.ThisSupplier.SupplierID.ToString();
        txtSupplierEmail.Text = SupplierBook.ThisSupplier.SupplierEmail;
        txtPhoneNo.Text = SupplierBook.ThisSupplier.PhoneNo;
        txtAddress.Text = SupplierBook.ThisSupplier.Address;
        txtStockAmount.Text = SupplierBook.ThisSupplier.StockAmount.ToString();
        txtDeliveryDate.Text = SupplierBook.ThisSupplier.DeliveryDate.ToString();
        chkInstock.Checked = SupplierBook.ThisSupplier.InStock;
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
            AnSupplier.SupplierID = SupplierID;

            AnSupplier.SupplierEmail = SupplierEmail;
            AnSupplier.Address = Address;
            AnSupplier.StockAmount = Convert.ToInt32(StockAmount);
            AnSupplier.PhoneNo = PhoneNo;
            AnSupplier.DeliveryDate = Convert.ToDateTime(DeliveryDate);

            AnSupplier.InStock = chkInstock.Checked;

            clsSupplierCollection SupplierList = new clsSupplierCollection();
            
            if(SupplierID == -1)
            {
                SupplierList.ThisSupplier = AnSupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = AnSupplier;
                SupplierList.Update();
            }
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}