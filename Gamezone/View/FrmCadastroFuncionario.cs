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
    public partial class FrmCadastroFuncionario : Form
    {
        int codFuncionario;
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        CargoFuncionarioDAO cargoDAO = new CargoFuncionarioDAO();
        CargoFuncionarioM cargoM = new CargoFuncionarioM();
        CadastroFuncionario cadFunc = new CadastroFuncionario();
        List<int> indexcargo = new List<int>();
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<CargoFuncionarioM> listaCargo = new List<CargoFuncionarioM>();
            listaCargo = cargoDAO.selectCargoFunc();
            listaCargo.ForEach(delegate (CargoFuncionarioM c)
            {
                comboBox1.Items.Add(c.DescricaoCargoFuncionario);
                indexcargo.Add(c.IdCargoFuncionario);
            });
            comboBox1.SelectedIndex = 0;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            int log = 1;
            if (comboBox1.SelectedIndex >= 0)
                log = cadFunc.cadUsuario(textBox1.Text, textBox2.Text, indexcargo[comboBox1.SelectedIndex]);
            switch (log)
            {
                case 0:
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    this.Close();
                    break;
                case 1:
                    MessageBox.Show("Nome muito curto!");
                    break;
                case 2:
                    MessageBox.Show("CPF inválido!");
                    break;
                case 3:
                    MessageBox.Show("Funcionário já cadastrado!");
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void atualizar(FuncionarioM func)
        {

            codFuncionario = func.IdFuncionario;
            textBox1.Text = func.NomeFuncionario;
            textBox2.Text = func.CpfFuncionario;
            label4.Visible = false;
            label5.Visible = true;



        }
        //qualquer comentario

        private void label5_Click(object sender, EventArgs e)
        {
            AtualizarFuncionario at = new AtualizarFuncionario();
            FuncionarioM func = new FuncionarioM();
            func.NomeFuncionario = textBox1.Text;
            func.CpfFuncionario = textBox2.Text;
            func.CargoFuncionarioM.IdCargoFuncionario = indexcargo[comboBox1.SelectedIndex];
            func.IdFuncionario = codFuncionario;
            int log = 1;
            if (comboBox1.SelectedIndex >= 0)
                log = at.atFuncionario(func);
            switch (log)
            {
                case 0:
                    MessageBox.Show("Funcionário editado com sucesso!");
                    this.Close();
                    break;
                case 1:
                    MessageBox.Show("Nome muito curto!");
                    break;
                case 2:
                    MessageBox.Show("CPF inválido!");
                    break;
                case 3:
                    MessageBox.Show("Funcionário já cadastrado!");
                    break;
            }
        }
    }
}
