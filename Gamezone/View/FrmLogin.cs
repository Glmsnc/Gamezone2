using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamezone.Controller;
using Gamezone.DAO;

namespace Gamezone.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioC usuarioC = new UsuarioC();
            EngineForm engineForm = new EngineForm();

            int login;

            login = usuarioC.loginValido(txtUsuario.Text, txtSenha.Text);
  
            switch(login)
            {
                case 0: // Falha no login
                    MessageBox.Show("Usuário ou senha inválida");
                    break;
                case 1: // Nível de acesso Administrador
                    engineForm.abrirForm(this, new FrmMenuEstoque());
                    break;
                case 2: // Nível de acesso Estoque
                    engineForm.abrirForm(this, new FrmMenuEstoque());
                    break;
            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●';

        }
    }
}
