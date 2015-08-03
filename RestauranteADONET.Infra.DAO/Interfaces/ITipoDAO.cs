using RestauranteADONET.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.Infra.DAO.Interfaces
{
    public interface ITipoDAO
    {
        List<Tipo> Listar();
        Tipo ListarPorId(int tipoId);
        void Gravar(Tipo tipo);
        void Deletar(Tipo tipo);
    }
}
