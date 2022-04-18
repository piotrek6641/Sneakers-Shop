<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="150px" Width="244px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        </p>
        <p>
            Enter customer name
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
