
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Entity
{
    public class AlunoEntity
    {
        public AlunoEntity()
        {
            Celular = "10101"; //Realizamento de teste de conferência de chegada/transitação do dado
        }

        public int idAluno { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime? dataNascimento { get; set; }
        public Nullable<DateTime> dataCadastro { get; set; }
        public Nullable<DateTime> dataAtualizacao { get; set; }

        public List<CursoEntity> CursosDoAluno { get; set; }


        public AcaoDoObjeto Acao { get; set; }
    }

    public enum AcaoDoObjeto
    {
        Nada =0,
        New =1,
        Update =2,
        Delete =3
    }

    
}
