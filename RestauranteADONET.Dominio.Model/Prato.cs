using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.Dominio.Model
{
    public class Prato
    {
        private int _pratoId;
        private string _nome;
        private string _descricao;
        private int _tipoId;
        private Tipo _tipo;
      
        public int pratoId
        {
            get { return _pratoId;}
            set { _pratoId = value;}
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public int tipoId
        {
            get { return _tipoId; }
            set { _tipoId = value; }
        }

        public virtual Tipo tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}
