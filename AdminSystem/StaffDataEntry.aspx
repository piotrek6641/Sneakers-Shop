<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="StaffID" runat="server" Text="StaffID" width="122px"></asp:Label>
            <asp:TextBox ID="TextStaffID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="StaffEmail" runat="server" Text="Email" width="122px"></asp:Label>
            <asp:TextBox ID="TextStaffEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="StaffPassword" runat="server" Text="Password" width="122px"></asp:Label>
            <asp:TextBox ID="TextStaffPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="StaffDateCreated" runat="server" Text="DateCreated"></asp:Label>
            <asp:TextBox ID="TextDateCreated" runat="server" OnTextChanged="TextDateCreated_TextChanged"></asp:TextBox>
            <br />
             
            <asp:CheckBox ID="IsAdmin" runat="server" Text="IsAdmin" />
            <br />
            <br />
            
            <asp:Button ID="StaffOK" runat="server" Text="OK" OnClick="StaffOK_Click" />
            <asp:Button ID="StaffCancel" runat="server" Text="Cancel" />
            <asp:Button ID="Find" runat="server" Text="Find" OnClick="btn_Find_Click" />
        </div>
    </form>
</body>
</html>
