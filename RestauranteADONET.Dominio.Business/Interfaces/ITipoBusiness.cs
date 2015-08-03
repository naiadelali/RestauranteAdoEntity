using RestauranteADONET.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.Dominio.Business.Interfaces
{
    public interface ITipoBusiness
    {
        List<Tipo> Listar();
        Tipo ListarPorId(int id);
        void Gravar(Tipo tipo);
        void Deletar(Tipo tipo);
    }
}
