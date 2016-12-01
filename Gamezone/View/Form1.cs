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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

       
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string coman = @"SELECT * FROM tbUsuario WHERE loginUsuario = @login AND senhaUsuario = @password";
            string strcon = "Data Source=GLM-PC;Initial Catalog=bdLoja;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            string login = textBox1.Text, password = textBox2.Text;
            
            try

            {


                SqlCommand comando = new SqlCommand(coman, conexao);

                comando.Parameters.AddWithValue("@login", textBox1.Text);
                comando.Parameters.AddWithValue("@password", textBox2.Text);
                conexao.Open();

                int valor = (int)comando.ExecuteScalar();
                if (valor > 0)
                {
                  
                    MessageBox.Show("Logado com sucesso. Sejam bem-vindo!");
                    Form3 cadPro = new WindowsFormsApplication2.Form3();
                    cadPro.Show();
                    
                   
                }
                else
                {
                    
                    MessageBox.Show("Dados incorretos!");

                }
            }

            catch (SqlException erro)

            {

                MessageBox.Show(erro + "Na conexão com o banco de dados");
            }

            finally
            {
                conexao.Close();


            }

        }
    }
}
