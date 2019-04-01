using Cadastro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Interface
{
    public interface IViewAlunos
    {

       event EventHandler Salvar;

         string Nome { get; set; }
         string Endereco { get; set; }
         string Cep { get; set; }
         string Telefone { get; set; }
         string Celular { get; set; }
         Nullable<System.DateTime> dataNascimento { get; set; }
         Nullable<System.DateTime> dataCadastro { get; set; }
         Nullable<System.DateTime> dataAtualizacao { get; set; }

        AcaoDoObjeto Acao { get; set; }

         List<AlunoEntity> ListaResultado { get; set; }

    }
}
