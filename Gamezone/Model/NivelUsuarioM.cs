using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    class NivelUsuarioM
    {
        private int idNivelUsuario;
        private String descricaoNivelUsuario;

        public int IdNivelUsuario
        {
            get
            {
                return idNivelUsuario;
            }

            set
            {
                idNivelUsuario = value;
            }
        }

        public string DescricaoNivelUsuario
        {
            get
            {
                return descricaoNivelUsuario;
            }

            set
            {
                descricaoNivelUsuario = value;
            }
        }
    }
}
