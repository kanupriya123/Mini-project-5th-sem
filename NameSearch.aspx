<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NameSearch.aspx.cs" Inherits="NameSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
     
        <asp:Panel ID="Panel1" runat="server">
            <p style="font-size:20pt;color:blue">Baby Names Finders Kit</p><br />
            Gender :
            <asp:DropDownList ID="gender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Both</asp:ListItem>
            </asp:DropDownList>
            &nbsp;Select Year :
            <asp:DropDownList ID="year" runat="server">
            </asp:DropDownList>
            &nbsp;Selection Type:
            <asp:DropDownList ID="top" runat="server">
                <asp:ListItem Value="0">All</asp:ListItem>
                <asp:ListItem Value="10">Top 10</asp:ListItem>
                <asp:ListItem Value="20">Top 20</asp:ListItem>
                <asp:ListItem Value="50">Top 50</asp:ListItem>
                <asp:ListItem Value="100">Top 100</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="filternow" runat="server" BackColor="#660066" Font-Bold="True" Font-Size="16pt" ForeColor="White" OnClick="filternow_Click" Text="Popular Names by Birth Year" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="18pt" ForeColor="Blue" Text="Filtered Child Names"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CaptionAlign="Top">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
        </asp:Panel>
    
   
    </div>
    </form>
</body>
</html>
