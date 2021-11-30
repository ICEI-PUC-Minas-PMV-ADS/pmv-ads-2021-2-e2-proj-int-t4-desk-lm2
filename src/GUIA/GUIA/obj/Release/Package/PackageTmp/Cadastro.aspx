<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="GUIA.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form" runat="server">
   <div class="container">
  <h2> Cadastro Aluno </h2>
      
   
           <div class="form-group">
      <label >Nome:</label>  
        <asp:TextBox ID="txtnome" runat="server" type="text" class="form-center"   Width="200px"></asp:TextBox>
           </div>
            <div class="form-group">
      <label>Email:</label>  
                 <asp:TextBox ID="txtemail" runat="server" type="text" class="form-center"   Width="200px"></asp:TextBox>
       
    </div>
            <div class="form-group">
      <label >Senha:</label>  
                 <asp:TextBox ID="txtsenha" runat="server" type="text" class="form-center"   Width="200px"></asp:TextBox>
    </div>

      <asp:Button ID="Button1" runat="server"  class="btn btn-default" Text="Cadastrar" OnClick="Button1_Click" />
    
       
    </div>
         </form>
</body>
</html>
