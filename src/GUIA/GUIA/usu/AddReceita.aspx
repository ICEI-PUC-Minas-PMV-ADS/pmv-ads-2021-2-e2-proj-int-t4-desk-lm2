<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddReceita.aspx.cs" Inherits="GUIA.usu.AddReceita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>GUIABOLSO</title>
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
    <div class="w3-bar w3-green w3-center">
  <div class="w3-bar w3-green">
    <a href="AddReceita.aspx" class="w3-bar-item w3-button w3-padding-large">Cadastro</a>
    <a href="AddJaReceita.aspx" class="w3-bar-item w3-button w3-padding-large">Já Cadastrados</a>
    <a href="VisaoGeral.aspx" class="w3-bar-item w3-button w3-padding-large">Voltar</a>
  </div>
</div>
    <div  id="cadastro" class="container" style="max-width:2000px;margin-top:70px">
      <h2>Cadastro de Receitas</h2>
      <br>
             <form id="form1" runat="server">
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Tipo da Receita:</asp:Label>
                <asp:TextBox ID="txttiporeceita" CssClass="form-control" TextMode="SingleLine"  Required runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label runat="server" Text="Label">Valor da Receita:</asp:Label>
                <asp:TextBox ID="txtvalorreceita" CssClass="form-control" TextMode="Number" Required runat="server"></asp:TextBox>
            </div>
            
            <br>
           
            <asp:Button ID="btnAddReceita" runat="server" class="btn btn-warning" Text="Cadastrar" OnClick="btnAddReceita_Click"/>
            </form>
        </div>
</body>
</html>
