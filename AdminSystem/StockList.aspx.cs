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
        if(IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();

        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "SneakerNo";
        lstStockList.DataTextField = "SneakerName";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SneakerNo"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
}