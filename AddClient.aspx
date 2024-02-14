<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="Cinema.AddClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="">Nome</asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCognome" runat="server" Text="">Cognome</asp:Label>
            <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
            <br />
            Sala:
            <asp:RadioButtonList ID="rdbSala" runat="server">
                <asp:ListItem Value="nord" >Sala Nord</asp:ListItem>
                <asp:ListItem Value="est" >Sala Est</asp:ListItem>
                <asp:ListItem Value="sud" >Sala Sud</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Tipo biglietto:
            <asp:RadioButtonList ID="rdbTipoBiglietto" runat="server">
                <asp:ListItem Value="ridotto" >Ridotto</asp:ListItem>
                <asp:ListItem Value="intero" >Intero</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Button ID="btnAcquista" runat="server" Text="Acquista" OnClick="btnAcquista_Click" />
            
            <div>
                Sala Nord:<asp:Label ID="lblNord" runat="server" Text="Label"></asp:Label>
                <br />
                Sala Est<asp:Label ID="lblEst" runat="server" Text="Label"></asp:Label>
                <br />
                Sala Sud<asp:Label ID="lblSud" runat="server" Text="Label"></asp:Label>
                <br />
                Totale Ridotti<asp:Label ID="lblRidotti" runat="server" Text="Label"></asp:Label>
            </div>


            <br />
        </div>
    </form>
</body>
</html>
