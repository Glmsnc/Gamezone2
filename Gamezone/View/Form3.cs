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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            String data;
            data = DateTime.Now.Day.ToString();
            data += "/" + DateTime.Now.Month.ToString();
            data += "/" + DateTime.Now.Year.ToString();
            data += " - " + DateTime.Now.Hour.ToString();
            data += ":" + DateTime.Now.Minute.ToString();
            label3.Text = data;
      
            string strProvider = "Data Source=GLM-PC;Initial Catalog=bdLoja;Integrated Security=True";
            
            string strSql = "SELECT * FROM tbJogo";


            SqlConnection con = new SqlConnection(strProvider);

            SqlCommand cmd = new SqlCommand(strSql, con);
            
            con.Open();

            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();

            da.Fill(dt);
            dGVProd.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //altera produto

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cadastra produto
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exclui produto
        }
    }
}
