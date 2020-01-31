<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmaR.aspx.cs" Inherits="Dinamicavei.ConfirmaR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel= "stylesheet"  href="css/style.css"/>
	<meta charset="utf-8"/>
    <title> Confirmar Reserva </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>  
                <a href="index.aspx">  <img src="img/logocar.png" style="margin-left: 20px; margin-top: 5px; margin-bottom: 0px"/> </a>
            </header>
            <div id="cadastro">
                <div id="imgc"></div>
                <div id="formcad">
                    <h1> Confirmar Reserva </h1>
                    <asp:TextBox ID="txtDatai" runat="server" Enabled="False" ></asp:TextBox><br />
                    <asp:TextBox ID="txtDataf" runat="server" Enabled="False" ></asp:TextBox><br />

                    <asp:TextBox ID="txtModelo" runat="server" Enabled="False" ></asp:TextBox><br />
                    <asp:TextBox ID="txtPlaca" runat="server"  Enabled="False"></asp:TextBox><br />
                    
                      <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"   />
                      <asp:Button ID="btnCadastrar" runat="server" Text="Confirmar" OnClick="btnCadastrar_Click"  />
                </div>

            </div>
            <footer> Desenvolvido por Mykaelly Oliveira 2020</footer>
        </div>
    </form>
</body>
</html>
