using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SneakerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        SneakerNo = Convert.ToInt32(Session["SneakerNo"]);
        if(IsPostBack == false)
        {
            if(SneakerNo != -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(SneakerNo);

        txtSneakerNo.Text = StockBook.ThisStock.SneakerNo.ToString();
        txtSneakerName.Text = StockBook.ThisStock.SneakerName;
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        chkAvailable.Checked = StockBook.ThisStock.Available;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

        //string SneakerNo = txtSneakerNo.Text;
        string SneakerName = txtSneakerName.Text;
        string DateAdded = txtDateAdded.Text;
        string Price = txtPrice.Text;
        
        string Error = "";
        Error = AStock.Valid(SneakerName, Price, DateAdded);

        if(Error == "")
        {
            AStock.SneakerNo = SneakerNo;

            AStock.SneakerName = SneakerName;
            
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
           
            AStock.Price = Convert.ToInt32(Price);

            AStock.Available = chkAvailable.Checked;

            clsStockCollection StockList = new clsStockCollection();

            if(SneakerNo == -1)
            {
                StockList.ThisStock = AStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(SneakerNo);
                StockList.ThisStock = AStock;
                StockList.Update();
            }

            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

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