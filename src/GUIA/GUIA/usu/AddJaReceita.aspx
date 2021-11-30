<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJaReceita.aspx.cs" Inherits="GUIA.usu.AddJaReceita" %>

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
      <h2>Todas as Receitas</h2>
      <br>
    
    <form id="form1" runat="server">
          <asp:Button runat="server" class="btn btn-danger" Text="Apagar Todas as receitas" OnClick="Unnamed1_Click" />

                <br><br>
                <asp:GridView runat="server" ID="Grid" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
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
              
    </form>
            </div>
</body>
</html>
