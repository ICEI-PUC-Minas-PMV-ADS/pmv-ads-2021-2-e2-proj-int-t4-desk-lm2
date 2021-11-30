<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MeuPerfil.aspx.cs" Inherits="GUIA.usu.MeuPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>GUIABOLSO</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="shortcut icon" href="icon.ico" type="image/x-icon">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

<style>
body {font-family: "Lato",sans-serif}
.mySlides {display: none}
</style>

</head>
<body>
      <!-- Navbar -->
<div class="w3-bar w3-green w3-center">
  <div class="w3-bar w3-green">
    <a href="VisaoGeral.aspx" class="w3-bar-item w3-button w3-padding-large">Visão Geral</a>
    <a href="Lancamentos.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Lançamentos</a>
    <a href="relatorios.html" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Relatórios</a>
    <a href="MeuPerfil.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Meu Perfil</a>
    <a href="../index.html" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Sair</a>
  </div>
</div>

   

        <div  id="cadastro" class="container" style="max-width:2000px;margin-top:70px">
      <h2>Alterar Meus Dados</h2>
      <br>
         <form id="form1" runat="server">
            <div class="form-group">
            <asp:Label runat="server" Text="Label">Nome:</asp:Label>
            <asp:TextBox ID="txtnome" CssClass="form-control" TextMode="SingleLine" placeholder="Digite seu nome"  runat="server"></asp:TextBox>
             </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Email:</asp:Label>
                <asp:TextBox ID="txtemail" CssClass="form-control" TextMode="Email" placeholder="Digite seu e-mail"  runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label  runat="server" Text="Label">Senha:</asp:Label>
                <asp:TextBox ID="txtsenha" CssClass="form-control" TextMode="SingleLine" placeholder="Digite sua senha"  runat="server"></asp:TextBox>
            </div>
            <br>
            <asp:Button ID="BtnCarregar" class="btn btn-danger" runat="server" Text="Carregar Meus Dados" OnClick="BtnCarregar_Click" />
            <asp:Button ID="btnAlterar" class="btn w3-blue" runat="server" Text="Confirmar Alterar Dados" OnClick="btnAlterar_Click" />
            
            </form>
         </div>


</body>
</html>
