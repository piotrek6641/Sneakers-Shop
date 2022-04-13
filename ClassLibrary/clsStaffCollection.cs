using System.Collections.Generic;
using System;
namespace ClassLibrary

{
    public class clsStaffCollection
    {

        List<clsStaff> mStaffList = new List<clsStaff>();
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
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

    }
}