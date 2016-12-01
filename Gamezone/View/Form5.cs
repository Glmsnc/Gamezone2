using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            cbIdade.Items.Add(0);
            cbIdade.Items.Add(10);
            cbIdade.Items.Add(12);
            cbIdade.Items.Add(14);
            cbIdade.Items.Add(16);
            cbIdade.Items.Add(18);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cadastra jogo
            MessageBox.Show("Entrou");
            string strProvider = "Data Source=GLM-PC;Initial Catalog=bdLoja;Integrated Security=True";

            string strSql = "SELECT * FROM tbJogo";
            SqlConnection con = new SqlConnection(strProvider);

            SqlCommand cmd = new SqlCommand(strSql, con);
            try
            {
                

                con.Open();


                cmd.CommandText = "INSERT INTO tbJogo (nomeJogo, descricaoJogo,  idGenero,  idPlataforma,  idDistribuidora, valorJogo, idClassificacaoJogo, tamanhoGBJogo, qtdEstoqueJogo ) VALUES (@nomeJogo, @descricaoJogo,  @idGenero,  @idPlataforma,  @idDistribuidora, @valorJogo, @idClassificacaoJogo, @tamanhoGBJogo, @qtdEstoqueJogo )";
                cmd.Parameters.AddWithValue("@nomeJogo ", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricaoJogo", txtDesc.Text);
                cmd.Parameters.AddWithValue("@idGenero", txtGen.Text);
                cmd.Parameters.AddWithValue("@idPlataforma", txtPlat.Text);
                cmd.Parameters.AddWithValue("@idDistribuidora", txtDis.Text);
                cmd.Parameters.AddWithValue("@valorJogo", txtValor.Text);
                cmd.Parameters.AddWithValue("@idClassificacaoJogo", cbIdade);
                cmd.Parameters.AddWithValue("@tamanhoGBJogo", txtTam.Text);
                cmd.Parameters.AddWithValue("@qtdEstoqueJogo", txtQtd.Text);
            }
            catch (SqlException erro)

            {

                MessageBox.Show(erro + "Na conexão com o banco de dados");
            }

            finally
            {
                con.Close();


            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Cadastra jogo
            MessageBox.Show("Entrou");
            string strProvider = "Data Source=GLM-PC;Initial Catalog=bdLoja;Integrated Security=True";

            string strSql = "SELECT * FROM tbJogo";
            SqlConnection con = new SqlConnection(strProvider);

            SqlCommand cmd = new SqlCommand(strSql, con);
            try
            {
                MessageBox.Show("Try!");

                con.Open();


                cmd.CommandText = "INSERT INTO tbJogo (nomeJogo, descricaoJogo,  idGenero,  idPlataforma,  idDistribuidora, valorJogo, idClassificacaoJogo, tamanhoGBJogo, qtdEstoqueJogo ) VALUES (@nomeJogo, @descricaoJogo,  @idGenero,  @idPlataforma,  @idDistribuidora, @valorJogo, @idClassificacaoJogo, @tamanhoGBJogo, @qtdEstoqueJogo )";
                cmd.Parameters.AddWithValue("@nomeJogo ", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricaoJogo", txtDesc.Text);
                cmd.Parameters.AddWithValue("@idGenero", txtGen.Text);
                cmd.Parameters.AddWithValue("@idPlataforma", txtPlat.Text);
                cmd.Parameters.AddWithValue("@idDistribuidora", txtDis.Text);
                cmd.Parameters.AddWithValue("@valorJogo", txtValor.Text);
                cmd.Parameters.AddWithValue("@idClassificacaoJogo", Convert.ToInt32(cbIdade));
                cmd.Parameters.AddWithValue("@tamanhoGBJogo", txtTam.Text);
                cmd.Parameters.AddWithValue("@qtdEstoqueJogo", txtQtd.Text);
                MessageBox.Show("Try!3");
            }
            catch (SqlException erro)

            {

                MessageBox.Show(erro + "Na conexão com o banco de dados");
            }

            finally
            {
                con.Close();


            }

        }
    }
}
