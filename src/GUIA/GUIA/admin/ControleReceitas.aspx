<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControleReceitas.aspx.cs" Inherits="GUIA.admin.ControleReceitas" %>

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
      <h2>Listagem de Receitas</h2>
          <br>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridViewReceitas" runat="server"  BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowCancelingEdit="GridViewReceitas_RowCancelingEdit" OnRowDeleting="GridViewReceitas_RowDeleting" OnRowEditing="GridViewReceitas_RowEditing" OnRowUpdating="GridViewReceitas_RowUpdating">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
    </form>
          </div>
</body>
</html>
