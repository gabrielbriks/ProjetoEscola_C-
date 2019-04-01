using Cadastro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Business.Util
{
    public class CursoBusiness
    {
        public List<CursoEntity> BuscarCursos( List<int> listaIdsAlunos )
        {
            List<CursoEntity> cursos =new List<CursoEntity>();

            


            return cursos;

        }

        public CursoEntity BuscarCurso()
        {
            CursoEntity curso = new CursoEntity();

            return curso;
        }
      

        public Operacao<CursoEntity> SalvarCurso(Operacao<CursoEntity> operacao)
        {

            return operacao;
        }

    }
}
