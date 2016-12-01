using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    public static class UsuarioLogadoM
    {
        private static int idUsuario;
        private static String loginUsuario;
        private static String senhaUsuario;
        private static NivelUsuarioM nivelFuncionarioM = new NivelUsuarioM();
        private static FuncionarioM funcionarioM = new FuncionarioM();

        public static int IdUsuario
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

        public static string LoginUsuario
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

        public static string SenhaUsuario
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

        internal static NivelUsuarioM NivelFuncionarioM
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

        internal static FuncionarioM FuncionarioM
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

        public static FuncionarioM FuncionarioM1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal static NivelUsuarioM NivelUsuarioM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public static UsuarioM UsuarioM
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
}
