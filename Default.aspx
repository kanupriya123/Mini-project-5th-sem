<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
    
        <asp:Label ID="Label1" runat="server" Font-Size="20pt" ForeColor="#3333FF" Text="Child Name Search and Analytic Kit"></asp:Label>
        <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BorderColor="#009900" BorderStyle="Dotted" BorderWidth="3px" Font-Bold="True" Font-Size="14pt" ForeColor="Red" OnClick="Button1_Click" Text="Search Top Names in selected year" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" BorderColor="#009900" BorderStyle="Dotted" BorderWidth="3px" Font-Bold="True" Font-Size="14pt" ForeColor="Red" OnClick="Button2_Click" Text="Analyze Specific Name in Graphic Format" />
        <br />
    </center>
    </div>
    </form>
</body>
</html>
