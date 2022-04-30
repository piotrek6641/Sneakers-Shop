<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderId" runat="server" Text="Order Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" BorderStyle="Outset" />
        <br />
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer Id"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderStatues" runat="server" Text="Order Statues"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderStatues" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffId" runat="server" Text="Staff Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;<asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" BorderStyle="Outset" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" BorderStyle="Outset" />
    </form>
</body>
</html>
