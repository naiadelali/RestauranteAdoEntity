using RestauranteADONET.EntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADONET.Dominio.Model;
namespace RestauranteADONET.EntityFramework
{
    public class PratoDao: IPratoDAO
    {
        public List<Prato> Listar()
        {
            using (DbContexto contexto = new DbContexto())
            {
                return contexto.Pratos.Include("Tipo").ToList();
            }
        }

        public void Gravar(Prato prato)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Prato prato)
        {
            throw new NotImplementedException();
        }
    }
}
