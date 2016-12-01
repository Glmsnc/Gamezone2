using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    class GeneroM
    {
        private int idGenero;
        private String descricaoGenero;

        public int IdGenero
        {
            get
            {
                return idGenero;
            }

            set
            {
                idGenero = value;
            }
        }

        public string DescricaoGenero
        {
            get
            {
                return descricaoGenero;
            }

            set
            {
                descricaoGenero = value;
            }
        }
    }
}
