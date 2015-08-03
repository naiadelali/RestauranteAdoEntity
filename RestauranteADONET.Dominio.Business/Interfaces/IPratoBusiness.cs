using RestauranteADONET.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.Dominio.Business.Interfaces
{
    public interface IPratoBusiness
    {
        List<Prato> Listar();

        void Gravar(Prato prato);

        void Deletar(Prato prato);
    }
}
