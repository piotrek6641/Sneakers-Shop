using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SneakerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        SneakerNo = Convert.ToInt32(Session["SneakerNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(SneakerNo);
        StockBook.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect back - N
        Response.Redirect("StockList.aspx");
    }

    
}