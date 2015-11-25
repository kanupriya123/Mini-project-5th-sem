<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResultChart.aspx.cs" Inherits="ResultChart" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <table>
            <tr>
                <td style="text-align:right"><asp:Label ID="Label1" runat="server" Text="Provide the name for popularity comparison"></asp:Label></td>
                <td style="text-align:left"><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align:right">Start Year</td>
                <td style="text-align:left">
                    <asp:DropDownList ID="year" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">Gender</td>
                <td style="text-align:left">
            <asp:DropDownList ID="gender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Both</asp:ListItem>
            </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">&nbsp;</td>
                <td style="text-align:left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Show Tabular Data" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Show Pie Chart" OnClick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Show Column Chart" OnClick="Button3_Click" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right" colspan="2">
                    <asp:Label ID="message" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        
        
    </center>
    </div>
    </form>
</body>
</html>
