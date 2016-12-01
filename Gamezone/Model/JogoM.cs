using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamezone.Model
{
    class JogoM
    {
        public int idJogo;
        public String nomeJogo;
        public String descricaoJogo;
        public int generoM;
        public int plataformaM;
        public int distribuidoraM;
        public float valorJogo;
        public int classificacaoJogoM;
        public float tamanhoGBJogo;
        public int qtdEstoqueJogo;

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

        internal int GeneroM
        {
            get
            {//
                return generoM;
            }

            set
            {
                generoM = value;
            }
        }

        internal int PlataformaM
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

        internal int DistribuidoraM
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

        public float ValorJogo
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

    
        public float TamanhoGBJogo
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

        internal DistribuidoraM DistribuidoraM1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal GeneroM GeneroM1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal PlataformaM PlataformaM1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal DAO.JogoDAO JogoDAO
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

    public class JOGO
    {
    }
}
