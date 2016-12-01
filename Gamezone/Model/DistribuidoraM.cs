using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    class DistribuidoraM
    {
        private int idDistribuidora;
        private String descricaoDistribuidora;

        public int IdDistribuidora
        {
            get
            {
                return idDistribuidora;
            }

            set
            {
                idDistribuidora = value;
            }
        }

        public string DescricaoDistribuidora
        {
            get
            {
                return descricaoDistribuidora;
            }

            set
            {
                descricaoDistribuidora = value;
            }
        }
    }
}
