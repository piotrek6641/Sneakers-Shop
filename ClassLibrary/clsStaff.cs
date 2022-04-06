using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffID;
        private string Login;
        private DateTime mDateCreated;
        private string Password;
        private Boolean isAdmin;
        private string email;
        public bool Active { get; set; }
        /*public int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        */
     
        public DateTime DateCreated
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }
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

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByLogin");
            if(DB.Count == 1)
            {

                StaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                Login = Convert.ToString(DB.DataTable.Rows[0]["Login"]);
                Password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                isAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["isAdmin"]);
                DateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}