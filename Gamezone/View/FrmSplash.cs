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
using Gamezone.View;


namespace Gamezone
{
    public partial class FrmSplash : Form
    {
        
        public FrmSplash()
        {
            InitializeComponent();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            EngineForm engineForm = new EngineForm();
            engineForm.abrirForm(this,new FrmLogin());
            
        }   
    }
}
