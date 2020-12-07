<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ANIMALE_PETSHOP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Login Animale Petshop</title> 
    <link rel="stylesheet" href="css/styleLogin.css" />
</head>
<body>
   <%--   <form id="form1" runat="server">
      <asp:Label ID="lblUser" runat="server" Text="Usuário:"></asp:Label>
&nbsp;<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblsenha" runat="server" Text="Senha:"></asp:Label>
&nbsp;<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="cmdEntrar" runat="server" OnClick="cmdEntrar_Click" Text="Entrar" />


    </form>--%>

    <section class="form-section">
      <h1><br/><br/></h1>

      <div class="form-wrapper">
        <form runat="server">
          <div class="input-block">
            <img src="Img menu/logoanimale menu.png" />
          </div>
          <div class="input-block">
            <label for="login-email">Usuário</label>
              <input type="text" id="txtUser" runat="server"/>
          </div>
          <div class="input-block">
            <label for="login-password" id="lblsenha">Password</label>
           <input type="password" id="txtSenha" runat="server"/>
          </div>
            <asp:Button ID="cmdEntrar" Text="Login" runat="server" OnClick="CmdEntrar_Click" CssClass="btn-login"/>
        </form>
      </div>
    </section>
<%--    <ul class="squares">
    </ul>
    <script src="js/scriptLogin.js"></script>--%>


</body>
</html>
