<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmation" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
