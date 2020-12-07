using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ANIMALE_PETSHOP
{
    public partial class Cad_Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdSalvar_Click(object sender, EventArgs e)
        {
            AnimalePetshop conexao = new AnimalePetshop();
            //Criar objeto FUNCIONARIO
            FUNCIONARIO f = new FUNCIONARIO();

            f.NOME_FUN = txtFun.Value;
            f.DATA_NASCIMENTO = Convert.ToDateTime(txtdat_nasc.Value);
            f.SEXO = txtSexo.Value;
            f.CPF = txtCPF.Value;
            f.EMAIL = txtemail.Value;
            f.TELEFONE = txttelefone.Value;
            
            conexao.FUNCIONARIO.Add(f);
            
            conexao.SaveChanges();

        }



}
}