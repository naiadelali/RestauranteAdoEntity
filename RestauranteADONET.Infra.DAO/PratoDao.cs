using RestauranteADONET.Dominio.Model;
using RestauranteADONET.Infra.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.Infra.DAO
{
    public class PratoDao : IPratoDAO
    {
     
        public List<Prato> Listar()
        {
            TipoDAO tipoDao = new TipoDAO();
            List<Prato> pratos = new List<Prato>();
            string sql = "SELECT * FROM PRATO";
            using (DataTable dt = DbComandos.Consultar(sql))
            {
                foreach (DataRow r in dt.Rows)
                {
                    Tipo tipo = tipoDao.ListarPorId((int)r["tipoId"]);
                    Prato prato = new Prato()
                    {
                        pratoId = (int)r["PratoId"],
                        descricao = r["descricao"].ToString(),
                        nome = r["nome"].ToString(),
                        tipoId = (int)r["tipoid"],
                        tipo = tipo
                     
                    };
                    pratos.Add(prato);
                }
            }
            return pratos;
        }

        public void Gravar(Prato prato)
        {
            List<SqlParameter> parametros;
            string sql = "";
            if (prato.pratoId <= 0)
            {
                sql = "INSERT INTO PRATO (nome, descricao, tipoid) VALUES (@nome, @descricao, @tipoid)";

            }
            else
            {
                sql = "UPDATE PRATO SET nome=@nome, descricao = @descricao, tipoid = @tipoid WHERE pratoid = @pratoid";
            }
            parametros = new List<SqlParameter>(){
                    new SqlParameter("@nome",prato.nome),
                    new SqlParameter("@descricao", prato.descricao),
                    new SqlParameter("@tipoId", prato.tipoId),
                    new SqlParameter("@pratoid",prato.pratoId)
                };
            DbComandos.Executar(sql, parametros);
        }

        public void Deletar(Prato prato)
        {
            List<SqlParameter> parametros = new List<SqlParameter>() { 
                new SqlParameter("@pratoid",prato.pratoId)
            };
            string sql = "DELETE FROM PRATO WHERE pratoid = @pratoid";
            DbComandos.Executar(sql, parametros);
        }
    }
}
