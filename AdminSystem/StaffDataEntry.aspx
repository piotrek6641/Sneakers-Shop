<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="StaffID" runat="server" Text="StaffID"></asp:Label>
            <asp:TextBox ID="TextStaffID" runat="server"></asp:TextBox>
            <asp:Label ID="StaffEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextStaffEmail" runat="server"></asp:TextBox>
            <asp:Label ID="StaffPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextStaffPassword" runat="server"></asp:TextBox>
            <asp:Label ID="StaffDateCreated" runat="server" Text="DateCreated"></asp:Label>
            <asp:TextBox ID="TextDateCreated" runat="server"></asp:TextBox>
             <asp:Label ID="StaffIsAdmin" runat="server" Text="IsAdmin"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server"/>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <asp:Button ID="StaffOK" runat="server" Text="OK" />
            <asp:Button ID="StaffCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
