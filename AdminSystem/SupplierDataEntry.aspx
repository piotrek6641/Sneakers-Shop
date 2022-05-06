<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID" width="87px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblSupplierEmail" runat="server" Text="Supplier Email" width="87px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtSupplierEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="87px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPhoneNo" runat="server" Text="PhoneNo" width="87px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStockAmount" runat="server" Text="Stock Amount" width="87px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtStockAmount" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date" width="87px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDeliveryDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkInstock" runat="server" Text="In stock" />
            <br />
        </div>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
    </form>
</body>
</html>
