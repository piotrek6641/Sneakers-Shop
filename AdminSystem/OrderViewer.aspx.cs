using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create new instance of class order
        clsOrder AnOrder = new clsOrder();

        // get the data from session object
        AnOrder = (clsOrder) Session["AnOrder"];

        // display the order id for this entry
        Response.Write(AnOrder.OrderId);

    }
}