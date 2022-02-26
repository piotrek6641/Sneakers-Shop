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
        // create new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // capture the order Id
        AnOrder.OrderId = txtOrderId.Text;

        // store the address in session object
        Session["AnOrder"] = AnOrder;

        //navigates to viewer page for order
        Response.Redirect("OrderViewer.aspx");


    }

}