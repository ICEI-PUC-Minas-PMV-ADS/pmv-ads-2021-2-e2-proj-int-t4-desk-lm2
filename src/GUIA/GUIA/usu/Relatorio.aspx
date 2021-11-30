<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Relatorio.aspx.cs" Inherits="GUIA.usu.Relatorio" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

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
    <div class="w3-bar w3-green w3-center">
  <div class="w3-bar w3-green">
    <a href="VisaoGeral.aspx" class="w3-bar-item w3-button w3-padding-large">Visão Geral</a>
    <a href="Lancamentos.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Lançamentos</a>
    <a href="Relatorio.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Relatórios</a>
    <a href="MeuPerfil.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Meu Perfil</a>
    <a href="../index.html" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Sair</a>
  </div>
</div>

     <div  id="cadastro" class="container" style="max-width:2000px;margin-top:70px">
      <h2>Valores Estatisticos</h2>
      <br>
   
     <form runat="server">     
        <div class="container">
          <div class="row">
            <div class="col-sm-4">
              <h3>DESPESAS MÊS</h3>
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
              
            <div class="col-sm-4">
               <h3>RECEITAS MÊS</h3>
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
            <div class="col-sm-4">
              <h3>DIFERENÇAS MÊS</h3>
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
        </div>
       
        
        </form>
         </div>

</body>
</html>
