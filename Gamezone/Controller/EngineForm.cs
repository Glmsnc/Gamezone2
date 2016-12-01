using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Gamezone.View;

namespace Gamezone.Controller
{
    class EngineForm
    {
        private static Form formNovo;

        public static void ThreadProc()
        {
            Application.Run(formNovo);
        }

        public void abrirForm(Form formAtuaL,Form formNew)
        {
            formNovo = formNew;
            Thread thread = new Thread(new ThreadStart(ThreadProc));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = false;
            thread.Start();
            formAtuaL.Close();
        }
    }
}
