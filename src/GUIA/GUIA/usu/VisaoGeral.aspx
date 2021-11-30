<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisaoGeral.aspx.cs" Inherits="GUIA.usu.VisaoGeral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="shortcut icon" href="icon.ico" type="image/x-icon">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
.card-columns {
  @include media-breakpoint-only(lg) {
    column-count: 20;
  }
  @include media-breakpoint-only(xl) {
    column-count: 20;
  }
}
</style>
</head>
<body>
    <!-- Navbar -->
<div class="w3-bar w3-green w3-center">
  <div class="w3-bar w3-green">
    <a href="VisaoGeral.aspx" class="w3-bar-item w3-button w3-padding-large">Visão Geral</a>
    <a href="Lancamentos.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Lançamentos</a>
    <a href="Relatorio.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Relatórios</a>
    <a href="MeuPerfil.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Meu Perfil</a>
    <a href="../index.html" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Sair</a>
  </div>
</div>

    
     <div class="container" style="max-width:1200px;margin-top:70px">
         <form id="visaogeral" runat="server">

    <div class="card-columns">
      <div class="card">
        <div class="card-body">
          <h5 class="card-title">Saldo geral</h5>
          <asp:GridView ID="GridView3" class="text-muted" runat="server" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
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
      </div>
  
  
      
  
  <div class="card">
    <div class="card-body">
      <h5 class="card-title">Acesso Rapido</h5>
      <a href="AddDespesa.aspx" class="btn btn-danger btn-block">DESPESA</a>
      <a href="AddReceita.aspx" class="btn btn-success btn-block">RECEITA</a>
      <a href="AddDiferenca.aspx" class="btn btn-warning btn-block">DIFERENÇA</a>
    </div>
  </div>
  
         <div class="card">
    <div class="card-body">
      <h5 class="card-title">Soma das Despesas</h5>
       
           <asp:GridView ID="GridView1" class="text-muted" runat="server" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
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
  </div>
   <div class="card">
    <div class="card-body">
      <h5 class="card-title">Soma das Receitas</h5>
       
           <asp:GridView ID="GridView2" class="text-muted" runat="server" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
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
  </div>
  

        </form>



</div>
  
</body>
</html>
