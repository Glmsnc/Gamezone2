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
    public partial class FrmCadastroUsuario : Form
    {
        int codFuncionario, codUsuario;
        List<int> indexfunc = new List<int>();
        List<int> indexnivel = new List<int>();
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void carregarDGV()
        {
            FuncionarioDAO fdao = new FuncionarioDAO();

            dataGridView1.DataSource = fdao.listaCadUser(1, codUsuario);
            //parametro pra pegar somente alguns registros
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

            carregarDGV();

            List<NivelUsuarioM> listNivel = new List<NivelUsuarioM>();
            NivelUsuarioDAO niveldao = new NivelUsuarioDAO();
            listNivel = niveldao.selectNivelUsuario();


            listNivel.ForEach(delegate (NivelUsuarioM m)
            {
                comboBox1.Items.Add(m.DescricaoNivelUsuario);
                indexnivel.Add(m.IdNivelUsuario);
            }
            );
            comboBox1.SelectedIndex = 0;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            CadastroUsuario cad = new CadastroUsuario();

            int count = dataGridView1.RowCount - 1;


            if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.RowCount != 1 && dataGridView1.CurrentRow.Index != count)
            {
                int log = cad.cadUsuario(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), indexnivel[comboBox1.SelectedIndex], textBox1.Text, textBox2.Text);
                switch (log)
                {
                    case 0:
                        MessageBox.Show("Nome de usuário cadastrado com sucesso!");
                        carregarDGV();
                        break;
                    case 1:
                        MessageBox.Show("Nome de usuário ou senha muito curtos!");
                        break;
                    case 2:
                        MessageBox.Show("Nome de usuário igual a senha!");
                        break;
                    case 3:
                        MessageBox.Show("Nome de usuário já existente!");

                        break;




                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void atualizar(UsuarioM usuarioM, int codigoUsuario, int codigoFuncionario)
        {
            codFuncionario = codigoFuncionario;
            codUsuario = codigoUsuario;
            label4.Visible = false;
            label6.Visible = true;
            textBox1.Text = usuarioM.LoginUsuario;
            textBox2.Text = usuarioM.SenhaUsuario;
            dataGridView1.DataSource = null;
            carregarDGV();


        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            AtualizarUsuario at = new AtualizarUsuario();
            UsuarioM um = new UsuarioM();
            um.IdUsuario = codUsuario;
            um.LoginUsuario = textBox1.Text;
            um.SenhaUsuario = textBox2.Text;
            um.NivelFuncionarioM.IdNivelUsuario = indexnivel[comboBox1.SelectedIndex];
            um.FuncionarioM.IdFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            int count = dataGridView1.RowCount - 1;


            if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.RowCount != 1 && dataGridView1.CurrentRow.Index != count)
            {
                int log = at.atUsuario(um);
                switch (log)
                {
                    case 0:
                        MessageBox.Show("Editado com sucesso!");
                        carregarDGV();
                        codUsuario = 0;
                        this.Close();
                        break;
                    case 1:
                        MessageBox.Show("Nome de usuário ou senha muito curtos!");
                        break;
                    case 2:
                        MessageBox.Show("Nome de usuário igual a senha!");
                        break;
                    case 3:
                        MessageBox.Show("Nome de usuário já existente!");

                        break;
                }
            }
        }
    }
}
