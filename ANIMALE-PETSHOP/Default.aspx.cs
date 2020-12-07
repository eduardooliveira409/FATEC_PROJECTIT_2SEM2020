using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ANIMALE_PETSHOP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdEntrar_Click(object sender, EventArgs e)
        {
 
            string usuario = txtUser.Value;
            string senha = txtSenha.Value;

            // Cria conexão com o banco de dados
            AnimalePetshop conexao = new AnimalePetshop();
            //Consulta objeto usuário baseado em login e senha
            LOGIN usuarios =
            conexao.LOGIN.FirstOrDefault(
                linha => linha.USUARIO_LOG.Equals(usuario) &&
                         linha.SENHA.Equals(senha)
                );
            
            if(usuarios != null)
            {
                //Login Bem sucedido
                Response.Redirect("Home.aspx");
            }
        }

        protected void cmdEntrar_Click1(object sender, EventArgs e)
        {

        }
    }
}