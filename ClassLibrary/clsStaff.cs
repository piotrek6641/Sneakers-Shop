using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int  mStaffID;
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
            if (DB.Count == 1)
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
        public String Valid(
            String StaffID,
            String Login,
            String Password,
            String email,
            String isAdmin,
            String DateCreated)
        {
            DateTime DateTemp;
            String error = "";
            
            if(StaffID.Length==0)
            {
                error += "ID cannot be blank";
            }
            if (StaffID.Length >20)
            {
                error += "ID cannot be more than 20 characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(DateCreated);
                if (DateTemp < DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                error = error + "The data was not a valid date : ";
            }
           
                
                if (Login == "")
                {
                    error = error + "Loggin cannot be empty field ";
                }

                if (Login.Length >50)
                {
                    error = error + "Loggin cannot be longer than 50 characters ";
                }
            
            
            return error;
        }
    }
}