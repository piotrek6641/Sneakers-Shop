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
        //create a new instance of clsStock
        clsStaff AStaff = new clsStaff();

        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];

        //display the data for this entry
        Response.Write(AStaff.StaffEmail);
        Response.Write(AStaff.StaffLogin);
        //Response.Write(AnOrder.Statues);
        Response.Write(AStaff.StaffPassword);
        Response.Write(AStaff.StaffIsAdmin);
    }
}