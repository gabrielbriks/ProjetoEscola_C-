using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Entity
{
    public class CursoEntity
    {
        public int IdCurso { get; set; }
        public int IdAluno { get; set; }
        public int IdMateria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; } 

    }
}


/*
 * 
 * 
 * [idCurso] [int] IDENTITY(1,1) NOT NULL,
	[idAluno] [int] NOT NULL,
	[idMateria] [int] NOT NULL,
	[Nome] [varchar](255) NULL,
	[Descricao] [varchar](255) NULL,
	[dataCadastro] [datetime] NULL,
	[dataAtualizacao] [datetime] NULL,
 * */
