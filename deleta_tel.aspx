<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deleta_tel.aspx.cs" Inherits="deleta_tel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Deseja realmente apagar o telefone ?</h1>
        <p>Nome:
            <asp:Label ID="txtnome" runat="server"></asp:Label>
        </p>
        <p>Telefone:
            <asp:Label ID="txttel" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Apagar" />
            <asp:HyperLink NavigateUrl="~/Default.aspx" runat="server">Voltar</asp:HyperLink>
        </p>
    </div>
    </form>
</body>
</html>
