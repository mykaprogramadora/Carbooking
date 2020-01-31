<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Dinamicavei.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel= "stylesheet"  href="css/style.css"/>
     <script src="Scripts/jquery-3.3.1.min.js"></script>
     <script src="Scripts/jquery.mask.min.js"></script>
	 <meta charset="utf-8"/>
     <title> Cadastro </title>
   <script type="text/javascript">
       $(document).ready(function () {
           	var options = {
				translation: {
					'A': {pattern: /[A-Z]/},

				}
           }
           $("#txtPlaca").mask('AAA-0000', options)
       })
   </script>
</head>
<body style="background-color: whitesmoke;" >
    <form id="form1" runat="server">
        <div>
             <header>  
                <a href="index.aspx"> <img src="img/logocar.png" style="margin-left: 20px; margin-top: 5px; margin-bottom: 0px"/></a>
            </header>
            <div id="cadastro">
                <div id="imgc"></div>
                <div id="formcad">
                    <h1> Cadastro de Veículos </h1>
                   <asp:TextBox ID="txtModelo" runat="server" PlaceHolder="Modelo do veículo*"></asp:TextBox><br />
                    <asp:TextBox ID="txtPlaca" runat="server" PlaceHolder="Placa* (Somente letras maiúsculas e números)" ClientIDMode="Static"></asp:TextBox><br />
                    <asp:DropDownList ID="cmbAno" runat="server" >
                        <asp:ListItem class="list" Text="2015" runat="server"></asp:ListItem>
                        <asp:ListItem class="list1" Text="2016" runat="server"></asp:ListItem>
                        <asp:ListItem class="list" Text="2017" runat="server"></asp:ListItem>
                        <asp:ListItem class="list1" Text="2018" runat="server"></asp:ListItem>
                        <asp:ListItem class="list" Text="2019" runat="server"></asp:ListItem>
                        <asp:ListItem class="list1" Text="2020" runat="server"></asp:ListItem>   
                    </asp:DropDownList><br />
                      <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"  />
                      <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                </div>

            </div>
            <footer> Desenvolvido por Mykaelly Oliveira 2020</footer>
        </div>
    </form>
</body>
</html>
