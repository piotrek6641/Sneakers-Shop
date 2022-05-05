using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Customerid;

    protected void Page_Load(object sender, EventArgs e)
    {
        Customerid = Convert.ToInt32(Session["Customerid"]);
        if (IsPostBack == false)
        {
            if (Customerid != -1)
            {
                DisplayCustomer();
            }
        }

    }

    private void DisplayCustomer()
    {
        clsCustomersCollection CustomerBook = new clsCustomersCollection();
        CustomerBook.ThisCustomer.Find(Customerid);
/*
        txtCustomerid.Text = CustomerBook.ThisCustomer.Customerid.ToString();
        txtCustomer_email.Text = CustomerBook.ThisCustomer.Customer_email;
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
        txtPhone.Text = CustomerBook.ThisCustomer.Phone.ToString();
        chkSpecialoffers.Checked = CustomerBook.ThisCustomer.Specialoffers;
*/
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clscustomers
        clsCustomers AnCustomers = new clsCustomers();
        string Customer_email = txtCustomer_email.Text;
        string DateAdded = txtDateAdded.Text;
        string Address = txtAddress.Text;
        string Phone = txtPhone.Text;
        string Error = "";
        Error = AnCustomers.Valid(Customer_email, Phone, DateAdded, Address);
        if (Error == "")
        {
            //capture customer email
            AnCustomers.Customerid = Customerid;
            AnCustomers.Customer_email = Customer_email;
            //capture rest attribute
            AnCustomers.DateAdded = Convert.ToDateTime(DateAdded);
            AnCustomers.Address = Address;
            AnCustomers.Phone = Phone;


            clsCustomersCollection CustomerList = new clsCustomersCollection();

            if (Customerid == -1)
            {
                CustomerList.ThisCustomer = AnCustomers;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(Customerid);
                CustomerList.ThisCustomer = AnCustomers;
                CustomerList.Update();
            }

            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomers AnCustomers = new clsCustomers();
        Int32 Customerid;
        //variable to store the result of the find operation
        Boolean Found = false;

        Customerid = Convert.ToInt32(txtCustomerid.Text);
        Found = AnCustomers.Find(Customerid);

        if (Found == true)
        {
            txtCustomer_email.Text = AnCustomers.Customer_email;
            txtDateAdded.Text = AnCustomers.DateAdded.ToString();
            txtAddress.Text = AnCustomers.Address;
            txtPhone.Text = AnCustomers.Phone;
            
        }
    }
}