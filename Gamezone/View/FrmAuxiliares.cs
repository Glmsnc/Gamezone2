using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamezone.DAO;
using Gamezone.Model;
using Gamezone.Controller;

namespace Gamezone.View
{
    public partial class FrmAuxiliares : Form
    {
        public FrmAuxiliares()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAuxiliares_Load(object sender, EventArgs e)
        {
            PlataformaC plataformaC = new PlataformaC();
            dgPlataforma.DataSource = plataformaC.selecPlataforma();
            dgPlataforma.Columns[0].Visible = false;

            GeneroC generoC = new GeneroC();
            dgGenero.DataSource = generoC.selectGenero();
            dgGenero.Columns[0].Visible = false;

            DistribuidoraC distribuidoraC = new DistribuidoraC();
            dgDistribuidora.DataSource = distribuidoraC.selecDistribuidora();
            dgDistribuidora.Columns[0].Visible = false;
           
        }

        private void txtPlataforma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadPlataforma_Click(object sender, EventArgs e)
        {
            PlataformaM plataformaM = new PlataformaM();
            PlataformaC plataformaC = new PlataformaC();
            String resultado;

            plataformaM.DescricaoPlataforma = txtPlataforma.Text.Trim();

            resultado = plataformaC.cadastrarPlataforma(plataformaM);
            MessageBox.Show(resultado);

            if (resultado.Equals("Plataforma " + plataformaM.DescricaoPlataforma + " cadastrada com sucesso."))
            {
                txtPlataforma.Clear();
            }

            dgPlataforma.DataSource = plataformaC.selecPlataforma();
            dgPlataforma.Columns[0].Visible = false;
        }

        private void btnCadGenero_Click(object sender, EventArgs e)
        {
            GeneroM generoM = new GeneroM();
            GeneroC generoC = new GeneroC();
            String resultado;

            generoM.DescricaoGenero = txtGenero.Text.Trim(); ;

            resultado = generoC.cadastrarGenero(generoM);
            MessageBox.Show(resultado);

            if (resultado.Equals("Gênero " + generoM.DescricaoGenero + " cadastrado com sucesso.")) {
                txtGenero.Clear();
            }
            dgGenero.DataSource = generoC.selectGenero();
            dgGenero.Columns[0].Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            EngineForm engineForm = new EngineForm();
            engineForm.abrirForm(this, new FrmMenuEstoque());
        }

        private void btnCadDistribuidora_Click(object sender, EventArgs e)
        {
            DistribuidoraM distribuidoraM = new DistribuidoraM();
            DistribuidoraC distribuidoraC = new DistribuidoraC();
            String resultado;

            distribuidoraM.DescricaoDistribuidora = txtDistribuidora.Text.Trim();

            resultado = distribuidoraC.cadastrarDistribuidora(distribuidoraM);
            MessageBox.Show(resultado);

            if (resultado.Equals("Distribuidora " + distribuidoraM.DescricaoDistribuidora + " cadastrada com sucesso.") )
            {
                txtDistribuidora.Clear();
            }
            dgDistribuidora.DataSource = distribuidoraC.selecDistribuidora();
            dgDistribuidora.Columns[0].Visible = false;
        }

        private void txtPesquisarPlataforma_KeyUp(object sender, KeyEventArgs e)
        {
            PlataformaC plataformaC = new PlataformaC();
            dgPlataforma.DataSource = plataformaC.pesquisarPlataforma(txtPesquisarPlataforma.Text);
            dgPlataforma.Columns[0].Visible = false;
        }


        private void txtPesquisarDistribuidora_KeyUp(object sender, KeyEventArgs e)
        {
            DistribuidoraC distribuidoraC = new DistribuidoraC();
            dgDistribuidora.DataSource = distribuidoraC.pesquisarDistribuidora(txtPesquisarDistribuidora.Text);
            dgDistribuidora.Columns[0].Visible = false;
        }

        private void txtPesquisarGenero_KeyUp(object sender, KeyEventArgs e)
        {
            GeneroC generoC = new GeneroC();
            dgGenero.DataSource = generoC.pesquisarGenero(txtPesquisarGenero.Text);
            dgGenero.Columns[0].Visible = false;
        }


        private void btnExcluirPlataforma_Click(object sender, EventArgs e)
        {
            if (dgPlataforma.CurrentRow.Cells[0] != null)
            {
                DialogResult dialogo = MessageBox.Show("Deseja excluir essa plataforma?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    PlataformaC plataformaC = new PlataformaC();
                    plataformaC.excluirPlataforma(Convert.ToInt32(dgPlataforma.CurrentRow.Cells[0].Value));

                    dgPlataforma.DataSource = plataformaC.selecPlataforma();
                    dgPlataforma.Columns[0].Visible = false;
                }
            }
            else {
                MessageBox.Show("Selecione uma plataforma para excluir!");
            }
        }

        private void btnEditPlataforma_Click(object sender, EventArgs e)
        {
            if (dgPlataforma.CurrentRow.Cells[0] != null)
            {
                DialogResult dialogo = MessageBox.Show("Deseja Editar essa plataforma?", "Confirmar Editação", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    PlataformaC plataformaC = new PlataformaC();
                    PlataformaM plataformaM = new PlataformaM();
                    String resultado;

                    plataformaM.IdPlataforma = Convert.ToInt32(dgPlataforma.CurrentRow.Cells[0].Value);
                    plataformaM.DescricaoPlataforma = txtPlataforma.Text;

                    resultado = plataformaC.editarPlataforma(plataformaM);
                    MessageBox.Show(resultado);
                    if (resultado.Equals("Plataforma Editada com sucesso.")) {
                        txtPlataforma.Clear(); }

                    dgPlataforma.DataSource = plataformaC.selecPlataforma();
                    dgPlataforma.Columns[0].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma plataforma para editar!");
            }
        }
    }
}
