<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerid" runat="server" Text="Customer Number"></asp:Label>
        <asp:TextBox ID="txtCustomerid" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomer_email" runat="server" Text="Customer_email" width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomer_email" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded" width="113px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="113px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhone" runat="server" Text="Phone" width="113px"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkSpecialoffers" runat="server" Text="Specialoffers" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
