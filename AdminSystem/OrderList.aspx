<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-selected="undefined" aria-sort="none">
            <br />
            &nbsp;&nbsp;
            <asp:ListBox ID="lstOrderList" runat="server" Height="307px" Width="327px"></asp:ListBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" BorderStyle="Outset" />
            &nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" BorderStyle="Outset" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" BorderStyle="Outset" />
            <br />
            <br />
            <br />
            <br />
            Enter Order Statues:&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" BorderStyle="Outset"></asp:TextBox>
            &nbsp;<br />
            [0 = Not Processed, 1 = Shipped, 2 = Furfilled]<br />
            <br />
            &nbsp;<asp:Button ID="btnApply" runat="server" BorderStyle="Outset" OnClick="btnApply_Click" Text="Apply" />
            &nbsp;
            <asp:Button ID="btnClear" runat="server" BorderStyle="Outset" OnClick="btnClear_Click" Text="Clear" />
        </div>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
