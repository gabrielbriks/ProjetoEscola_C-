using Cadastro.Business.Util;
using Cadastro.Entity;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Business
{
    public class AlunoBusiness
    {

     


        private CursoBusiness _CursoBusiness;

        /*SIGLETON*/
        /*singleton tem como definição garantir que uma classe tenha somente uma instância e fornecer um ponto global de acesso a mesma

        Read more: http://www.linhadecodigo.com.br/artigo/3397/singleton-padrao-de-projeto-com-microsoft-net-c-sharp.aspx#ixzz5hzWEGh37
        */
        public CursoBusiness NegocioCursos
        {

            get
            {

                if (_CursoBusiness == null)
                {
                    _CursoBusiness = new CursoBusiness();
                }
                return _CursoBusiness;
            }
        }

        #region Buscar

        public List<AlunoEntity> BuscarAlunos(FilterAluno filter)
        {
            var retorno = new List<AlunoEntity>();


            using (Database.schoolSystemEntities banco = new schoolSystemEntities())
            {

                var query = banco.Aluno.AsQueryable();

                if (filter.idAluno != 0 )
                {
                    query = query.Where(x => x.idAluno == filter.idAluno);

                }

                if (!string.IsNullOrEmpty(filter.Nome))
                {
                    query = query.Where(x => x.Nome.StartsWith(filter.Nome));

                }

                var idsAlunos = query.Select(s => s.idAluno).Distinct().ToList();



                 var listaCursosDosAlunos = NegocioCursos.BuscarCursos(idsAlunos);



                foreach (var item in query)
                {
                    var aluno = new AlunoEntity();
                    aluno.Endereco = item.Endereco;
                    aluno.idAluno = item.idAluno;
                    aluno.Telefone = item.Telefone;
                    aluno.dataNascimento = item.dataNascimento;
                    aluno.dataCadastro = item.dataCadastro;
                    aluno.dataAtualizacao = item.dataAtualizacao;
                    aluno.Celular = item.Celular;
                    aluno.Cep = item.Cep;
                    aluno.CursosDoAluno = listaCursosDosAlunos.Where(curso => curso.IdAluno == item.idAluno).ToList();



                    retorno.Add(aluno);






                }


            }


            return retorno;
        }

        public AlunoEntity BuscarAluno(int idAluno, string Nome)
        {
            var aluno = new AlunoEntity();

            return aluno;
        }

        public AlunoEntity BuscarAluno(int idAluno)
        {

            var aluno = new AlunoEntity();


            using (Database.schoolSystemEntities banco = new schoolSystemEntities())
            {


                var queryJoin = (from a in banco.Aluno
                                 where a.idAluno == idAluno
                                 select new
                                 {
                                     a.Endereco,
                                     a.idAluno,
                                     a.Nome,
                                     a.Telefone
                                     // a.Curso

                                 }).FirstOrDefault();


                if (queryJoin != null)
                {

                    aluno.Nome = queryJoin.Nome;
                    aluno.idAluno = queryJoin.idAluno;
                    aluno.Telefone = queryJoin.Telefone;
                    aluno.Endereco = queryJoin.Endereco;


                }



                //  Articoli art = db.Articoli.Where((x) => x.CodArt == "ART001").FirstOrDefault();

                //  MessageBox.Show(art.DesArt);
            }

            return aluno;

        }


        #endregion

        public Operacao<AlunoEntity> SalvarAluno(Operacao<AlunoEntity> operacao)
        {

            if (operacao.Entidade.Acao == AcaoDoObjeto.New)
            {

                /**Validacoes*/

                PossoSalvarAluno(operacao);

                if (!operacao.Mensgens.Exists(x=>x.TipoMensagem == TipoMensagem.Erro))
                {

                    try
                    {
                        using (Database.schoolSystemEntities banco = new schoolSystemEntities())
                        {

                            var alunoBancoDados = ConvertAluno(operacao.Entidade);

                            
                            banco.Aluno.Add(alunoBancoDados);
                            
                        
                            banco.SaveChanges();


                        }


                       


                    }
                    catch (Exception ex)
                    {

                        throw;
                    }

                }
            
            }


            else
                if (operacao.Entidade.Acao == AcaoDoObjeto.Update)
            {

            }
            else
            {
                if (operacao.Entidade.Acao == AcaoDoObjeto.Delete)
                {

                }
            }


            return operacao;
        }

        //convertendo alunoEntity(classe/objeto) para Aluno(ENTIDADE), para entao cadastra os dados no bd.

        #region Auxiliar
        public Aluno ConvertAluno(AlunoEntity alunoEntity)
        {
            return new Aluno
            {

                Celular = alunoEntity.Celular,
                Cep = alunoEntity.Cep,
                idAluno = alunoEntity.idAluno,
                Nome = alunoEntity.Nome,
                dataAtualizacao = alunoEntity.dataAtualizacao,
                dataNascimento = alunoEntity.dataNascimento,
                dataCadastro =alunoEntity.dataCadastro,
              Endereco = alunoEntity.Endereco,
              Telefone = alunoEntity.Telefone


            };

        }

        public void PossoSalvarAluno(Operacao<AlunoEntity> operacao)
        {


            if (operacao.Entidade.Acao != AcaoDoObjeto.New)
            {
                if (operacao.Entidade.idAluno <= 0)
                {
                    operacao.Mensgens.Add(new Mensagem { Texto = "O campo id esta com valor incorreto", TipoMensagem = TipoMensagem.Erro });
                }

            }

            if ( string.IsNullOrWhiteSpace(operacao.Entidade.Nome))
            {
                operacao.Mensgens.Add(new Mensagem { Texto ="O campo nome esta vazio", TipoMensagem =TipoMensagem.Erro });
            }

            



        }

        #endregion

    }


}
