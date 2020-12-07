using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ANIMALE_PETSHOP.Cadastros
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdSalvar_Click(object sender, EventArgs e)
        {
            AnimalePetshop conexao = new AnimalePetshop();
            //Criar objeto FUNCIONARIO
            CLIENTE c = new CLIENTE();

            c.NOME_CLI = txtCli.Value;
            c.DATA_NASCIMENTO = Convert.ToDateTime(txtdat_nasc.Value);
            c.SEXO = txtSexo.Value;
            c.CPF = txtCPF.Value;
            c.EMAIL = txtemail.Value;
            c.TELEFONE = txttelefone.Value;

            conexao.CLIENTE.Add(c);

            conexao.SaveChanges();
        }

        protected void CmdLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}