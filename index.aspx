<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Dinamicavei.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel= "stylesheet"  href="css/style.css"/>
	<meta charset="utf-8"/>
        <title> Inicio </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>  
                 <img src="img/logocar.png" style="margin-left: 20px; margin-top: 5px; margin-bottom: 0px"/>
            </header>
            <div id="imagem">
               
                  <div id="opcoes">
                    <p> Bem-Vindo(a) ao CarBooking! </p>
                    <p> Escolha uma das opções para continuar:</p>
                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastro de veículos" OnClick="btnCadastro_Click" />
                    <asp:Button ID="btnReserva" runat="server" Text="Reserva de veículos" OnClick="btnReserva_Click" />
                </div>
            </div>
            <footer> Desenvolvido por Mykaelly Oliveira 2020</footer>
        </div>
    </form>
</body>
</html>
