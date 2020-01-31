<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reserva.aspx.cs" Inherits="Dinamicavei.Reserva" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel= "stylesheet"  href="css/style.css"/>
     <script src="Scripts/jquery-3.4.1.min.js"></script>
     <script src="Scripts/jquery.maskedinput.min.js"></script>
	<meta charset="utf-8"/>
    <title> Reserva </title>
 <script type="text/javascript">
         jQuery(function ($) {
   
             $("#txtInicio").mask("99/99/9999");
             $("#txtFim").mask("99/99/9999");
             $("#txtHorai").mask("99:99");
             $("#txtHoraf").mask("99:99");
     });
     </script>
</head>
<body style="background-color: whitesmoke;">
    <form id="form1" runat="server">
        <div>
            <header>  
                  <a href="index.aspx"> <img src="img/logocar.png" style="margin-left: 20px; margin-top: 5px; margin-bottom: 0px"/> </a>
            </header>
            <div id="imagem2">
  
                <div id="agenda">
                    <asp:TextBox ID="txtInicio" runat="server" PlaceHolder="Quando?" ClientIDMode="Static"></asp:TextBox>
                    <asp:TextBox ID="txtHorai" runat="server" PlaceHolder= "00:00" ClientIDMode="Static"></asp:TextBox>
                    <asp:TextBox ID="txtFim" runat="server" PlaceHolder="Até quando?" ClientIDMode="Static"></asp:TextBox>
                    <asp:TextBox ID="txtHoraf" runat="server" PlaceHolder="00:00" ClientIDMode="Static"></asp:TextBox>
                    <asp:Button ID="btnBusca" runat="server" Text="Buscar" OnClick="btnBusca_Click" />
                </div>
            </div>
               <asp:Panel ID="veiculos" runat="server" class="someCssClass"></asp:Panel>
      
           
            <footer> Desenvolvido por Mykaelly Oliveira 2020</footer>
        </div>
    </form>
</body>
</html>

