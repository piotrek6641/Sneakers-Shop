<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="OrderId" runat="server" Text="Order id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="CustomerId" runat="server" Text="Customer Id"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="DataAdded" runat="server" Text="Date Added"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Statues" runat="server" Text="Statues"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStatues" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="StaffId" runat="server" Text="Staff Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblerror" runat="server" Text="[lblError]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
