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
using Gamezone.Model;
namespace Gamezone.View
{
    public partial class FrmEditar : Form
    {
        UsuarioDAO userdao = new UsuarioDAO();
        FuncionarioDAO funcdao = new FuncionarioDAO();
        CargoFuncionarioDAO cargodao = new CargoFuncionarioDAO();
        NivelUsuarioDAO niveldao = new NivelUsuarioDAO();
        public FrmEditar()
        {
            InitializeComponent();
        }

        public void carregarDGV_Usuario()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = userdao.selectTodoUsuario();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void carregarDGV_Funcionario()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcdao.listaCadUser(0, 0);
            //parametro pra pegar somente alguns registros
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void carregarDGV_Cargo()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = cargodao.selectCargo();
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void FormEditar_Load(object sender, EventArgs e)
        {




            carregarDGV_Funcionario();
            carregarDGV_Usuario();
            carregarDGV_Cargo();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }









        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            int count = dataGridView1.RowCount - 1;


            if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.RowCount != 1 && dataGridView1.CurrentRow.Index != count)
            {


                DialogResult confirm = MessageBox.Show("Deseja excluir o login do usuário selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {


                    funcdao.deleteFuncionario(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    carregarDGV_Funcionario();
                    carregarDGV_Usuario();





                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            int count = dataGridView2.RowCount - 1;


            if (dataGridView2.SelectedRows.Count != 0 && dataGridView2.RowCount != 1 && dataGridView2.CurrentRow.Index != count)
            {
                DialogResult confirm = MessageBox.Show("Deseja excluir o login do usuário selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {


                    userdao.deletUsuario(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                    carregarDGV_Usuario();

                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            int count = dataGridView3.RowCount - 1;


            if (dataGridView3.SelectedRows.Count != 0 && dataGridView3.RowCount != 1 && dataGridView3.CurrentRow.Index != count)
            {
                DialogResult confirm = MessageBox.Show("Deseja excluir o login do usuário selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (cargodao.deletCargo(Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value)))
                        MessageBox.Show("Impossível excluir pois existem funcionários cadastrados com este cargo!");

                    carregarDGV_Cargo();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            FrmCadastroUsuario frm = new FrmCadastroUsuario();
            frm.Show();
            UsuarioDAO dao = new UsuarioDAO();
            UsuarioM um = new UsuarioM();
            um = dao.selectUsuario(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), "");
            frm.atualizar(um, Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), um.FuncionarioM.IdFuncionario);
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            FrmCadastroCargo frm = new FrmCadastroCargo();
            frm.Show();
            CargoFuncionarioDAO dao = new CargoFuncionarioDAO();
            CargoFuncionarioM cf = new CargoFuncionarioM();
            cf = dao.selectCargoFuncID(Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
            frm.atualizar(cf);
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            FrmCadastroFuncionario frm = new FrmCadastroFuncionario();
            frm.Show();
            FuncionarioDAO dao = new FuncionarioDAO();
            FuncionarioM func = new FuncionarioM();
            func = dao.selectFuncionario("", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.atualizar(func);
            this.Close();
        }
    }

}