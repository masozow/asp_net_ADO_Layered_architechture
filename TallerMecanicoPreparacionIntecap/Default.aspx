<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TallerMecanicoPreparacionIntecap._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Probando</title>
    <link rel="Stylesheet" type="text/css" href="~CSS/sitio.css" />
</head>
<body>
    <div class="alerta_exito"><span></span></div>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="alerta_exito" runat="server"><span> <%:Mensaje%> </span></div>
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
    </div>
        
    </form>
</body>
</html>
