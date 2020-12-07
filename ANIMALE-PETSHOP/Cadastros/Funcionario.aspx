<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="ANIMALE_PETSHOP.Cad_Funcionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
      <!-- Content Header (Page header) -->
      <section class="content-header">
        <div class="container-fluid">
      <h2>Cadastro de Funcionarios</h2>
    <!--      <div class="divMeioInputs">      -->  
        <form>
          <div class="card-body">
            <!-- INPUTS E LABEL -->
            <div class="form-group">
              <label for="nome">Nome Funcionario</label>
              <input type="text" class="form-control" id="txtFun" runat="server" placeholder="Digite um nome">
            </div>
            <div class="form-group">
              <label for="Data">Data Nascimento</label>
              <input type="date" class="form-control" id="txtdat_nasc" runat="server">
            </div>
            <div class="form-group">
              <label for="sexo">Sexo</label>
              <input type="text" class="form-control" id="txtSexo" runat="server" placeholder="M-MASCULINO F-FEMININO">
            </div>
            <div class="form-group">
              <label for="cpf">CPF</label>
              <input type="text" class="form-control" id="txtCPF" runat="server" placeholder="999.999.999-99">
            </div>
            <div class="form-group">
              <label for="email">Email</label>
              <input type="email" class="form-control" id="txtemail" runat="server" placeholder="exemplo@seuemail.com.br">
            </div>
            <div class="form-group">
              <label for="telefone">Telefone</label>
              <input type="tel" class="form-control" id="txttelefone" runat="server" placeholder="(17) 99999-9999">
            </div>
          <!-- /.card-body -->
          <div class="card-footer">
            <asp:Button  ID="cmdSalvar" Text="Salvar" CssClass="btn btn-primary" runat="server" OnClick="CmdSalvar_Click" /><asp:Button  ID="cmdLimpar" Text="Limpar" CssClass="btn btn-primary" runat="server" OnClick="CmdLimpar_Click" />
          </div>
        </form>
      </div>
    </section>
  </div>
    <script type="text/javascript" src="../js/srcipt.js"></script>
    <script  type="text/javascript" src="../js/js.js"></script>
    <script  type="text/javascript" src="../js/AdminLTE.js"></script>
    <script  type="text/javascript" src="../js/Layout.js"></script>
    <script  type="text/javascript" src="../js/PushMenu.js"></script>
</asp:Content>
