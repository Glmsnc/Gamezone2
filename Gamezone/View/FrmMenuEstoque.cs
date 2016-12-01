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

namespace Gamezone.View
{
    public partial class FrmMenuEstoque : Form
    {
        EngineForm engineForm = new EngineForm();
        public FrmMenuEstoque()
        {
            InitializeComponent();
        }

        private void FrmMenuEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            UsuarioC usuarioC = new UsuarioC();

            usuarioC.deslogarUsuario();
            engineForm.abrirForm(this, new FrmLogin());
            
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            engineForm.abrirForm(this,new FrmJogo());
        }

        private void btnAuxiliares_Click(object sender, EventArgs e)
        {
            engineForm.abrirForm(this, new FrmAuxiliares());
        }
    }
}
