using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    class JogoM
    {
        private int idJogo;
        private String nomeJogo;
        private String descricaoJogo;
        private GeneroM generoM;
        private PlataformaM plataformaM;
        private DistribuidoraM distribuidoraM;
        private double valorJogo;
        private int classificacaoJogoM;
        private double tamanhoGBJogo;
        private int qtdEstoqueJogo;

        public int IdJogo
        {
            get
            {
                return idJogo;
            }

            set
            {
                idJogo = value;
            }
        }

        public string NomeJogo
        {
            get
            {
                return nomeJogo;
            }

            set
            {
                nomeJogo = value;
            }
        }

        public string DescricaoJogo
        {
            get
            {
                return descricaoJogo;
            }

            set
            {
                descricaoJogo = value;
            }
        }

        internal GeneroM GeneroM
        {
            get
            {
                return generoM;
            }

            set
            {
                generoM = value;
            }
        }

        internal PlataformaM PlataformaM
        {
            get
            {
                return plataformaM;
            }

            set
            {
                plataformaM = value;
            }
        }

        internal DistribuidoraM DistribuidoraM
        {
            get
            {
                return distribuidoraM;
            }

            set
            {
                distribuidoraM = value;
            }
        }

        public double ValorJogo
        {
            get
            {
                return valorJogo;
            }

            set
            {
                valorJogo = value;
            }
        }

        public int ClassificacaoJogoM
        {
            get
            {
                return classificacaoJogoM;
            }

            set
            {
                classificacaoJogoM = value;
            }
        }

        public double TamanhoGBJogo
        {
            get
            {
                return tamanhoGBJogo;
            }

            set
            {
                tamanhoGBJogo = value;
            }
        }

        public int QtdEstoqueJogo
        {
            get
            {
                return qtdEstoqueJogo;
            }

            set
            {
                qtdEstoqueJogo = value;
            }
        }
    }
}
