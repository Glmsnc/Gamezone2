using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamezone.Model;
using Gamezone.Controller;
namespace Gamezone.View
{
    public partial class FrmCadastroCargo : Form
    {
        int codCargo;
        CadastroCargo c = new CadastroCargo();

        public FrmCadastroCargo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            int log = c.cadCargo(textBox2.Text);
            switch (log)
            {
                case 0:
                    MessageBox.Show("Cargo já existe!");
                    break;
                case 1:
                    MessageBox.Show("Nome muito curto!");
                    break;
                case 2:
                    MessageBox.Show("Cadastrado com sucesso!");
                    this.Close();
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCargo_Load(object sender, EventArgs e)
        {

        }

        public void atualizar(CargoFuncionarioM cargo)
        {

            codCargo = cargo.IdCargoFuncionario;
            textBox2.Text = cargo.DescricaoCargoFuncionario;
            label4.Visible = false;
            label1.Visible = true;



        }

        private void label1_Click(object sender, EventArgs e)
        {
            AtualizarCargo at = new AtualizarCargo();
            CargoFuncionarioM cargo = new CargoFuncionarioM();
            cargo.IdCargoFuncionario = codCargo;
            cargo.DescricaoCargoFuncionario = textBox2.Text;

            int log = at.cadCargo(cargo);
            switch (log)
            {
                case 0:
                    MessageBox.Show("Cargo já existe!");
                    break;
                case 1:
                    MessageBox.Show("Nome muito curto!");
                    break;
                case 2:
                    MessageBox.Show("Editado com sucesso!");
                    this.Close();
                    break;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
