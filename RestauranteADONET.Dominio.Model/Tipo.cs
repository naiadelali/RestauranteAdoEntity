using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteADONET.Dominio.Model
{
    public class Tipo
    {
        private int _tipoId;
        private string _nome;

        private IEnumerable<Prato> _pratos;
        public int tipoId
        {
            get { return _tipoId; }
            set { _tipoId = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public virtual IEnumerable<Prato> pratos
        {
            get { return _pratos; }
            set { _pratos = value; }
        }

    }
}
