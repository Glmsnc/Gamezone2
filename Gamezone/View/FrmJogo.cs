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
        int CodJogo;
        List<int> indexgenero = new List<int>();
        List<int> indexdistribuidora = new List<int>();
        List<int> indexplataforma = new List<int>();
        List<int> indexclassificaojogo = new List<int>();
        public FrmJogo()
        {
            InitializeComponent();
        }
        private void carregarDGV(int i)
        {
            JogoDAO jdao = new JogoDAO();

            dgJogo.DataSource = jdao.listaCadJogo(i, CodJogo);
        }
        private void FrmJogo_Load(object sender, EventArgs e)
        {

            carregarDGV(1);


            List<DistribuidoraM> listDistribuidora = new List<DistribuidoraM>();
            DistribuidoraDAO DistriDao = new DistribuidoraDAO();
            listDistribuidora = DistriDao.selectDistribuidora();
            List<GeneroM> listGenero = new List<GeneroM>(); //cbGenero
            GeneroDAO GenDao = new GeneroDAO();
            listGenero = GenDao.selectGenero();
            List<PlataformaM> listPlataforma = new List<PlataformaM>();//cbPlataforma
            PlataformaDAO PlatDao = new PlataformaDAO();
            listPlataforma = PlatDao.selectPlataforma();
            

            listDistribuidora.ForEach(delegate (DistribuidoraM m)
            {


                cbDistribuidora.Items.Add(m.DescricaoDistribuidora);
                indexdistribuidora.Add(m.IdDistribuidora);
            }
            );
            //cbDistribuidora.SelectedIndex = 0;
            listGenero.ForEach(delegate (GeneroM m)
            {
                cbGenero.Items.Add(m.DescricaoGenero);
                indexgenero.Add(m.IdGenero);
            }
         );
           // cbGenero.SelectedIndex = 0;
            
             listPlataforma.ForEach(delegate (PlataformaM m)
               {
                   cbClassificacao.Items.Add(m.DescricaoPlataforma);
                    indexplataforma.Add(m.IdPlataforma);
                }
            );
            //cbClassificacao.SelectedIndex = 0;
            listPlataforma.ForEach(delegate (PlataformaM m)
            {
                cbPlataforma.Items.Add(m.DescricaoPlataforma);
                indexplataforma.Add(m.IdPlataforma);
            }
            );
//cbPlataforma.SelectedIndex = 0;



        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
           
            JogoDAO dao = new JogoDAO();
            JogoM j = new JogoM();
            try
            {
                if (txtNome != null || txtDescricao != null || cbGenero != null || cbPlataforma != null || cbDistribuidora != null || cbClassificacao != null || txtPreco != null || txtTamanhoGB != null || txtQuantidade != null)
                {
                    j.NomeJogo = txtNome.Text;
                    j.DescricaoJogo = txtDescricao.Text;
                    int n = Convert.ToInt32(cbGenero.SelectedValue);
                    MessageBox.Show("N:" + n);
                    //j.plataformaM= Convert.ToInt32(cbPlataforma.SelectedValue);
                    j.PlataformaM = 1;
                    //j.distribuidoraM = Convert.ToInt32(cbDistribuidora.SelectedValue);
                    j.DistribuidoraM = 1;
                    //j.generoM= Convert.ToInt32(cbGenero.SelectedValue); 
                    j.GeneroM = 1;
                    j.ValorJogo = float.Parse(txtPreco.Text);
                    // j.classificacaoJogoM= Convert.ToInt32(cbClassificacao.SelectedValue);
                    j.ClassificacaoJogoM = 2;
                    j.TamanhoGBJogo = float.Parse(txtTamanhoGB.Text);
                    j.QtdEstoqueJogo = int.Parse(txtQuantidade.Text);

                
                    bool log = true;
                    log = dao.cadastrarJogo(j);
                    MessageBox.Show(log.ToString());
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar")
                        ;
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro ao cadastrar!!");

            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void SAIR_Click(object sender, EventArgs e)
        {

        }

        private void EDITAR_Click(object sender, EventArgs e)
        {

        }

        private void EXCLUIR_Click(object sender, EventArgs e)
        {
                    }



        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgJogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

