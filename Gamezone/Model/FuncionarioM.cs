using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
  public class FuncionarioM
    {
        private int idFuncionario;
        private String nomeFuncionario;
        private String cpfFuncionario;
        private CargoFuncionarioM cargoFuncionarioM = new CargoFuncionarioM();

        public int IdFuncionario
        {
            get
            {
                return idFuncionario;
            }

            set
            {
                idFuncionario = value;
            }
        }

        public string NomeFuncionario
        {
            get
            {
                return nomeFuncionario;
            }

            set
            {
                nomeFuncionario = value;
            }
        }

        public string CpfFuncionario
        {
            get
            {
                return cpfFuncionario;
            }

            set
            {
                cpfFuncionario = value;
            }
        }

        internal CargoFuncionarioM CargoFuncionarioM
        {
            get
            {
                return cargoFuncionarioM;
            }

            set
            {
                cargoFuncionarioM = value;
            }
        }

        public CargoFuncionarioM CargoFuncionarioM1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public class FuncionarioCD
    {
    }
}
