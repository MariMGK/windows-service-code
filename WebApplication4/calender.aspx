<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calender.aspx.cs" Inherits="WebApplication4.calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:ScriptManager ID="sc" runat="server" EnablePartialRendering="true">
    </asp:ScriptManager>
       
             <asp:UpdatePanel ID="updpnl" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:Calendar ID="Calendar1"  Width="100%" BackColor="Blue" ForeColor="Yellow" Font-Name="Script" Font-Size="24pt" Font-Bold="true" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>



       
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>
                 </asp:UpdatePanel>
    </form>
</body>
</html>
