using RestauranteADONET.Dominio.Model;
using RestauranteADONET.Infra.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace RestauranteADONET.Infra.DAO
{
    public class TipoDAO:ITipoDAO
    {

      
        public List<Tipo> Listar()
        {
           
            List<Tipo> tipos = new List<Tipo>();
            string sql = "SELECT * FROM TIPO";

            using (DataTable dt = DbComandos.Consultar(sql))
            {
                foreach (DataRow r in dt.Rows)
                {
                    Tipo tipo = new Tipo()
                    {
                        nome = r["nome"].ToString(),
                        tipoId = (int)r["tipoId"]
                      
                    };

                    tipos.Add(tipo);
                }
            }
            return tipos;
        }

        public Tipo ListarPorId(int tipoId)
        {
            Tipo tipo = new Tipo();
            string sql = "SELECT * FROM TIPO WHERE TIPOID = @TIPOID";
            List<SqlParameter> parameters = new List<SqlParameter>(){
                new SqlParameter("@TipoId",tipoId)
            };

            using (DataTable dt = DbComandos.Consultar(sql,parameters))
            {
                foreach (DataRow r  in dt.Rows)
                {
                    tipo.tipoId = (int)r["tipoid"];
                    tipo.nome = r["nome"].ToString();
                }
            }

            return tipo;

        }

        public void Gravar(Dominio.Model.Tipo tipo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Dominio.Model.Tipo tipo)
        {
            throw new NotImplementedException();
        }
    }
}
