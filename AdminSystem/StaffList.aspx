<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="LstStaffList" runat="server" OnSelectedIndexChanged="LstStaffList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="btnAdd_Click" Text="ADD" />
            <asp:Button ID="Edit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="height: 26px; width: 37px" />

            <asp:Button ID="Delete" runat="server" OnClick="btnDelete_Click" Text="Delete" />

        </p>
        
        <asp:Label runat="server" Text="Enter Login"></asp:Label>
        
        

        
        <asp:TextBox ID="LoginFilter" runat="server"></asp:TextBox>
        
        

        
        <p>
            <asp:Button ID="Apply" runat="server" Text="Apply" OnClick="Apply_Click" />
            <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" />
        </p>
        
        

        
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        
        

        
    </form>
</body>
</html>
