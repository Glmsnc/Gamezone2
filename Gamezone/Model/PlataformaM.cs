using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    class PlataformaM
    {
        private int idPlataforma;
        private String descricaoPlataforma;

        public int IdPlataforma
        {
            get
            {
                return idPlataforma;
            }

            set
            {
                idPlataforma = value;
            }
        }

        public string DescricaoPlataforma
        {
            get
            {
                return descricaoPlataforma;
            }

            set
            {
                descricaoPlataforma = value;
            }
        }
    }
}
