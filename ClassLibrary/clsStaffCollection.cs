using System.Collections.Generic;
using System;
namespace ClassLibrary

{
    public class clsStaffCollection
    {

        clsStaff mThisStaff = new clsStaff();
        List<clsStaff> mStaffList = new List<clsStaff>();

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);


        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffLogin = Convert.ToString(DB.DataTable.Rows[Index]["Login"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["isAdmin"]);
                AStaff.DateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@Login", mThisStaff.StaffLogin);
            DB.AddParameter("@Password", mThisStaff.StaffPassword);
            DB.AddParameter("@isAdmin", mThisStaff.StaffIsAdmin);
            DB.AddParameter("@DateCreated", mThisStaff.DateCreated);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByLogin(String Login)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@login", Login);
            DB.Execute("sproc_tblStaff_FilterByLogin");
            PopulateArray(DB);
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@Login", mThisStaff.StaffLogin);
            DB.AddParameter("@Password", mThisStaff.StaffPassword);
            DB.AddParameter("@isAdmin", mThisStaff.StaffIsAdmin);
            DB.AddParameter("@DateCreated", mThisStaff.DateCreated);
            DB.Execute("sproc_tblStaff_Update");
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
                {
                return mThisStaff;
            }
            set
                {
                mThisStaff = value;
            }
        }

    }
}