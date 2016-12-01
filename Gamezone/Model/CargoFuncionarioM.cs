using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
   public class CargoFuncionarioM
    {
        private int idCargoFuncionario;
        private String descricaoCargoFuncionario;

        public int IdCargoFuncionario
        {
            get
            {
                return idCargoFuncionario;
            }

            set
            {
                idCargoFuncionario = value;
            }
        }

        public string DescricaoCargoFuncionario
        {
            get
            {
                return descricaoCargoFuncionario;
            }

            set
            {
                descricaoCargoFuncionario = value;
            }
        }
    }
}
