using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.Model;
using Gamezone.DAO;
namespace Gamezone.Controller
{
    class AtualizarCargo
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

        public int cadCargo(CargoFuncionarioM cargo)
        {
            CargoFuncionarioDAO c = new CargoFuncionarioDAO();

            if (cargo.DescricaoCargoFuncionario.Length < 2)
                return 1;
            else if (c.alterarCargo(cargo))
                return 0;
            else
                return 2;
        }
    }
}
