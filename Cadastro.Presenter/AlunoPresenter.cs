using Cadastro.Business;
using Cadastro.Entity;
using Cadastro.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Presenter
{
    public class AlunoPresenter
    {
        public IViewAlunos View { get; set; }


        private AlunoBusiness _AlunoBusiness;

        /*SIGLETON*/
        /*singleton tem como definição garantir que uma classe tenha somente uma instância e fornecer um ponto global de acesso a mesma

        Read more: http://www.linhadecodigo.com.br/artigo/3397/singleton-padrao-de-projeto-com-microsoft-net-c-sharp.aspx#ixzz5hzWEGh37
        */
        public AlunoBusiness NegocioAlunos
        {

            get {

                if (_AlunoBusiness == null)
                {
                    _AlunoBusiness = new AlunoBusiness();
                }
                return _AlunoBusiness;
            }
        }

      
        public AlunoPresenter(IViewAlunos view)
        {

            View = view;

            View.Salvar += View_Salvar;
        }
        //Sender == Remetente
        private void View_Salvar(object sender, EventArgs e)
        {
            var operacao = new Cadastro.Business.Util.Operacao<AlunoEntity>();



            operacao.Entidade = GetView();


            NegocioAlunos.SalvarAluno(operacao);

            var filtro = new FilterAluno();

            View.ListaResultado = NegocioAlunos.BuscarAlunos(filtro);


        }

        public AlunoEntity GetView()
        {

            return new AlunoEntity
            {
                Celular = View.Celular,
                Acao = AcaoDoObjeto.New,
                Nome = View.Nome,
                Cep = View.Cep,
                dataCadastro = DateTime.Now,
                dataAtualizacao = DateTime.Now,
                dataNascimento = View.dataNascimento,
                Endereco = View.Endereco,
                Telefone = View.Telefone
                

            };
        }
    }
}
