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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

        //capture the Sneaker Name
        AStock.SneakerName = txtSneakerName.Text;

        //capture rest attributes
        AStock.DateAdded = DateTime.Parse(txtDateAdded.Text);
        AStock.Price = Int32.Parse(txtPrice.Text);
        AStock.SneakerNo = Int32.Parse(txtSneakerNo.Text);

        //store the address in the session object
        Session["AStock"] = AStock;

        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 SneakerNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        
        SneakerNo = Convert.ToInt32(txtSneakerNo.Text);
        Found = AStock.Find(SneakerNo);

        if(Found == true)
        {
            txtSneakerName.Text = AStock.SneakerName;
            txtPrice.Text = AStock.Price.ToString();
            txtDateAdded.Text = AStock.DateAdded.ToString();
            //chkAvailable
        }
    }
}