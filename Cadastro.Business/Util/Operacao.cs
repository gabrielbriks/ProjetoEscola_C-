using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Business.Util
{
    public class Operacao<E> //"E" de Entidade; poderia ser "T"
       where E : class
    {
        public Operacao()
        {
            Mensgens = new List<Mensagem>();
        }

        public E Entidade { get; set; }

        public bool HasErro { get; set; }

        public List<Mensagem> Mensgens { get; set; }
             

    }

    public class Mensagem
    {
        public TipoMensagem TipoMensagem { get; set; }

        public string Texto { get; set; }
    }

    public enum TipoMensagem
    {
        Erro =1,
        Aviso =2

    }
}
