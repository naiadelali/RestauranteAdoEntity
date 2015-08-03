using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADONET.Dominio.Model;
using RestauranteADONET.Dominio.Business.Interfaces;
using RestauranteADONET.EntityFramework;
namespace RestauranteADONET.Dominio.Business
{
    public class PratoBusiness:IPratoBusiness
    {
        private readonly PratoDao _pratoDao = new PratoDao();
        //private readonly PratoDao _pratoDao = new PratoDao();
        public List<Prato> Listar()
        {
            return _pratoDao.Listar();
        }

        public void Gravar(Prato prato)
        {
            _pratoDao.Gravar(prato);
        }

        public void Deletar(Prato prato)
        {
            _pratoDao.Deletar(prato);
        }
    }
}
