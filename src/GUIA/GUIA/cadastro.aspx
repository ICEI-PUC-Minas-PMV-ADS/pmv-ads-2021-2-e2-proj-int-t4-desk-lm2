<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="GUIA.Cadastro" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>GUIA DE BOLSO</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
    
<div class="w3-bar w3-green w3-center">
  <div class="w3-bar w3-green">
    <a href="index.html" class="w3-bar-item w3-button w3-padding-large">Home</a>
    <a href="login.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Login</a>
    <a href="cadastro.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Cadastro</a>
  </div>
</div>
     <div  id="cadastro" class="container" style="max-width:2000px;margin-top:70px">
      <h2>Realizar Cadastro</h2>
      <br>
 
        <form id="cad_form" runat="server">
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Nome:</asp:Label>
                <asp:TextBox ID="cad_nome" CssClass="form-control" TextMode="SingleLine" placeholder="Digite seu nome" Required runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Email:</asp:Label>
                <asp:TextBox ID="cad_email" CssClass="form-control" TextMode="Email" placeholder="Digite seu e-mail" Required runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label  runat="server" Text="Label">Senha:</asp:Label>
                <asp:TextBox ID="cad_senha" CssClass="form-control" TextMode="Password" placeholder="Digite sua senha" Required runat="server"></asp:TextBox>
            </div>
            <br>
            <asp:Button ID="BtnCadastrar" runat="server" class="btn btn-warning" Text="Cadastrar" OnClick="BtnCadastrar_Click" />
        </form>

         </div>
</body>
</html>
