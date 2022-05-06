using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                //update the list box
                DisplayOrdrs();

            }
            
        }

    }

    void DisplayOrdrs()
    {
        //create instance of the order collection
        clsOrderCollection OrderBook = new clsOrderCollection();
        // find record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for this record
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.DateAdded.ToString();
        txtOrderStatues.Text = OrderBook.ThisOrder.Statues.ToString();
        txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsOrder AnOrder = new clsOrder();
        //string OrderId = txtOrderId.Text;
        string CustomersId = txtCustomerId.Text;
        string OrderStatues = txtOrderStatues.Text;
        string DateAdded = txtOrderDate.Text;
        string StaffId = txtStaffId.Text;
        string Error = "";
        Error = AnOrder.Valid(CustomersId, OrderStatues, DateAdded, StaffId);
        if (Error == "")
        {

            //capture the horder number
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomersId);
            AnOrder.Statues = Convert.ToByte(OrderStatues);
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            //Session["AnOrder"] = AnOrder;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            //set the thisorder property
            //OrderList.ThisOrder = AnOrder;
            //add the new record
            //OrderList.Add();
            //redirect to the viewer page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        //AnOrder.OrderId = Int32.Parse(txtOrderId.Text);

        // capturing the rest of the attributes
        //AnOrder.CustomerId = Int32.Parse(txtCustomerId.Text);
        //AnOrder.Statues = Byte.Parse(txtOrderStatues.Text);
        //AnOrder.DateAdded = DateTime.Parse(txtOrderDate.Text);
        //AnOrder.StaffId = Int32.Parse(txtStaffId.Text);

        //store the address in the session object
        //Session["AnOrder"] = AnOrder;

        //navigate to the viewer page
        //Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderNo);
        if (Found == true )
        {
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text  = AnOrder.DateAdded.ToString();
            txtOrderStatues.Text  = AnOrder.Statues.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}