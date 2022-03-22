using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private string Login;
        private DateTime mDateAdded;
        private string Password;
        private Boolean isAdmin;
        private string email;
        public bool Active { get; set; }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public DateTime DateCreated { get; set; }
        public bool StaffIsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }
        public string StaffPassword
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public string StaffLogin
        {
            get
            {
                return Login;
            }
            set
            {
                Login = value;
            }
        }
            
        public string StaffEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public bool Find(string Login)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@login", Login);
            DB.Execute("sproc_tblStaff_FilterByLogin");
            if(DB.Count == 1)
            {
                Login = Convert.ToString(DB.DataTable.Rows[0]["Login"]);
                Password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                isAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["isAdmin"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}