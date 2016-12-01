using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.DAO;
namespace Gamezone.Controller
{
    class CadastroCargo
    {
        internal CargoFuncionarioDAO CargoFuncionarioDAO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int cadCargo(String desc)
        {
            CargoFuncionarioDAO c = new CargoFuncionarioDAO();

            if (desc.Length < 2)
                return 1;
            else if (c.cadastroCargo(desc))
                return 0;
            else
                return 2;
        }
    }
}
