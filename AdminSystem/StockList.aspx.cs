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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SneakerNo;

        if(lstStockList.SelectedIndex != -1)
        {
            SneakerNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["SneakerNo"] = SneakerNo;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SneakerNo;

        if(lstStockList.SelectedIndex != -1)
        {
            SneakerNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["SneakerNo"] = SneakerNo;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}