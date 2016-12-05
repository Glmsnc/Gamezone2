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
    public partial class FrmJogo : Form
    {
        List<PlataformaM> listPlataforma = new List<PlataformaM>();
        List<GeneroM> listGenero = new List<GeneroM>();
        List<DistribuidoraM> listDistribuidora = new List<DistribuidoraM>();
        public FrmJogo()
        {
            InitializeComponent();
        }
       
        private void carregarAuxiliares()
        {
            PlataformaC plataformaC = new PlataformaC();
            listPlataforma = plataformaC.plataformasCadastradas();

            foreach (PlataformaM plataformaM in listPlataforma)
            {
                cbPlataforma.Items.Add(plataformaM.DescricaoPlataforma);
            }

            GeneroC generoC = new GeneroC();
            listGenero = generoC.generosCadastrados();

            foreach (GeneroM generoM in listGenero)
            {
                cbGenero.Items.Add(generoM.DescricaoGenero);
            }

            DistribuidoraC distribuidoraC = new DistribuidoraC();
            listDistribuidora = distribuidoraC.distribuidorasCadastradas();

            foreach (DistribuidoraM distribuidoraM in listDistribuidora)
            {
                cbDistribuidora.Items.Add(distribuidoraM.DescricaoDistribuidora);
            }
        }
        private void FrmJogo_Load(object sender, EventArgs e)
        {
            carregarAuxiliares();
        }
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            JogoM jogoM = new JogoM();
            JogoC jogoC = new JogoC();
            GeneroM generoM = new GeneroM();
            PlataformaM plataformaM = new PlataformaM();
            DistribuidoraM distribuidoraM = new DistribuidoraM();
            String mensagem="";

            try
            {
                generoM.IdGenero = listGenero[cbGenero.SelectedIndex].IdGenero;
            }
            catch
            {
                mensagem += "Selecione um gênero.";
            }

            try
            {
                plataformaM.IdPlataforma = listPlataforma[cbPlataforma.SelectedIndex].IdPlataforma;
            }
            catch
            {
                mensagem += "\nSelecione uma plataforma.";
            }

            try
            {
                distribuidoraM.IdDistribuidora = listDistribuidora[cbDistribuidora.SelectedIndex].IdDistribuidora;
            }
            catch
            {
                mensagem += "\nSelecione uma distribuidora.";
            }

            try
            {
                if (cbClassificacao.SelectedItem.Equals("Livre"))
                {
                    jogoM.ClassificacaoJogoM = 0;
                }
                else
                {
                    jogoM.ClassificacaoJogoM = Convert.ToInt32(cbClassificacao.SelectedItem);
                }
            }
            catch
            {
                mensagem += "\nSelecione uma faixa etária.";
            }

            if (mensagem.Equals(""))
            {
                try
                {
                    jogoM.NomeJogo = txtNome.Text.Trim();
                    jogoM.DescricaoJogo = txtDescricao.Text.Trim();
                    jogoM.GeneroM = generoM;
                    jogoM.PlataformaM = plataformaM;
                    jogoM.DistribuidoraM = distribuidoraM;
                    jogoM.QtdEstoqueJogo = Convert.ToInt32(txtQuantidade.Text.Trim());
                    jogoM.ValorJogo = (float)Convert.ToDouble(txtPreco.Text.Trim());
                    jogoM.TamanhoGBJogo = (float)Convert.ToDouble(txtTamanhoGB.Text.Trim());    
                }
                catch
                {
                    jogoM.QtdEstoqueJogo = 0;
                    jogoM.ValorJogo = 0;
                    jogoM.TamanhoGBJogo = 0;
                }
                MessageBox.Show(jogoC.cadastrarJogo(jogoM));
            }else
            {
                MessageBox.Show(mensagem);
            }       
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            EngineForm engineForm = new EngineForm();
            engineForm.abrirForm(this,new FrmJogo());
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDistribuidora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

