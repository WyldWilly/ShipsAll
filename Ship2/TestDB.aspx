<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestDB.aspx.cs" Inherits="Ship2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ships Database</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ships in the Database
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br /><br />
            Ship Types
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            <br /><br />
            Init-Table Contents
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
