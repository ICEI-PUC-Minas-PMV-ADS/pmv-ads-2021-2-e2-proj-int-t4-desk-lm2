<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GerenciaDesp.aspx.cs" Inherits="GUIA.admin.GerenciaDesp" %>

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
     <a href="GerenciaUser.aspx" class="w3-bar-item w3-button w3-padding-large">Usuarios</a>
    <a href="ControleUsers.aspx" class="w3-bar-item w3-button w3-padding-large">Controle de Usuarios</a>
    <a href="GerenciaDesp.aspx" class="w3-bar-item w3-button w3-padding-large">Despesas</a>
    <a href="ControleDespesas.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Controle de Despesas</a>
    <a href="GerenciaRec.aspx" class="w3-bar-item w3-button w3-padding-large">Receitas</a>
    <a href="ControleReceitas.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Controle de Receitas</a>
    <a href="GerenciaDif.aspx" class="w3-bar-item w3-button w3-padding-large">Diferenças</a>
    <a href="ControleDiferencas.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Controle de Diferenças</a>
    <a href="../index.html" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Sair</a>
  </div>
         </div>
     <div  id="cadastro" class="container" style="max-width:2000px;margin-top:70px">
      <h2>Cadastro de Despesas</h2>
      <br>
 
        <form id="cad_form" runat="server">
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Descrição:</asp:Label>
                <asp:TextBox ID="txtdescricao" CssClass="form-control" TextMode="SingleLine" Required runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Valor da Despesa:</asp:Label>
                <asp:TextBox ID="txtvalor" CssClass="form-control" TextMode="Number" Required runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Tipo da Despesa:</asp:Label>
                <asp:TextBox ID="txttipodespesa" CssClass="form-control" TextMode="SingleLine"  Required runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Label">Data de Vencimento da Despesa:</asp:Label>
               <asp:TextBox ID="txtDataVencimento" CssClass="form-control" TextMode="SingleLine" placeholder="DD/MM/AA" pattern="(((0[1-9]|[12][0-9]|3[01])([-./])(0[13578]|10|12)([-./])(\d{4}))|(([0][1-9]|[12][0-9]|30)([-./])(0[469]|11)([-./])(\d{4}))|((0[1-9]|1[0-9]|2[0-8])([-./])(02)([-./])(\d{4}))|((29)(\.|-|\/)(02)([-./])([02468][048]00))|((29)([-./])(02)([-./])([13579][26]00))|((29)([-./])(02)([-./])([0-9][0-9][0][48]))|((29)([-./])(02)([-./])([0-9][0-9][2468][048]))|((29)([-./])(02)([-./])([0-9][0-9][13579][26])))"  Required runat="server"></asp:TextBox> 
            </div>
            <br>
           
            <asp:Button ID="btnAddDespesa" runat="server" class="btn btn-warning" Text="Cadastrar" OnClick="btnAddDespesa_Click"/>
        </form>
            </div>
</body>
</html>
