using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
   public class UsuarioM
    {
        private int idUsuario;
        private String loginUsuario;
        private String senhaUsuario;
        private NivelUsuarioM nivelFuncionarioM = new NivelUsuarioM();
        private FuncionarioM funcionarioM = new FuncionarioM();

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string LoginUsuario
        {
            get
            {
                return loginUsuario;
            }

            set
            {
                loginUsuario = value;
            }
        }

        public string SenhaUsuario
        {
            get
            {
                return senhaUsuario;
            }

            set
            {
                senhaUsuario = value;
            }
        }

        internal NivelUsuarioM NivelFuncionarioM
        {
            get
            {
                return nivelFuncionarioM;
            }

            set
            {
                nivelFuncionarioM = value;
            }
        }

        internal FuncionarioM FuncionarioM
        {
            get
            {
                return funcionarioM;
            }

            set
            {
                funcionarioM = value;
            }
        }
    }
}
