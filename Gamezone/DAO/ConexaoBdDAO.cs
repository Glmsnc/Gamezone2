using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Gamezone.DAO
{
    class ConexaoBdDAO
    {
        public SqlConnection conexaoSQL() {

            try
            {
                return new SqlConnection(@"Data Source=GLM-PC;Initial Catalog=bdLoja;Integrated Security=True");
            }
            catch(Exception e)
            {
                return null;
            }
            
        }
     
    }
}
