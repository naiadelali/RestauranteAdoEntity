using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADONET.Dominio.Model;
using RestauranteADONET.Dominio.Business.Interfaces;
using RestauranteADONET.Infra.DAO;
namespace RestauranteADONET.Dominio.Business
{
    public class TipoBusiness:ITipoBusiness
    {
        private readonly TipoDAO _tipoDao = new TipoDAO();
        public List<Tipo> Listar()
        {
            return _tipoDao.Listar();
        }

        public Tipo ListarPorId(int id)
        {
            return _tipoDao.ListarPorId(id);
        }

        public void Gravar(Tipo tipo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Tipo tipo)
        {
            throw new NotImplementedException();
        }
    }
}
