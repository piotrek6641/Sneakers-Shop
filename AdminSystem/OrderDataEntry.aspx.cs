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
            //AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomersId);
            AnOrder.Statues = Convert.ToByte(OrderStatues);
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            Session["AnOrder"] = AnOrder;
            //redirect to the viewer page
            Response.Write("OrderViewer.aspx");
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
}