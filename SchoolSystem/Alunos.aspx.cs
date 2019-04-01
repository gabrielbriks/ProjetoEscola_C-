using Cadastro.Entity;
using Cadastro.Interface;
using Cadastro.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class Alunos : System.Web.UI.Page, IViewAlunos
    {


        public AlunoPresenter Presenter { get; set; }




        protected void Page_Init(object sender, EventArgs e)
        {
            btnSalvar.Click += BtnSalvar_Click;

            Presenter = new AlunoPresenter(this);


        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            Salvar(sender, e);


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        public void CarregaDados()
        {

            GridDados.DataSource = ListaResultado;
            GridDados.DataBind();
        }

        public string Nome
        {

            get
            {

                return txtNomeAluno.Text;

            }

            set
            {

                txtNomeAluno.Text = value;
            }
        }
        public string Endereco

        {

            get
            {

                return txtEndereco.Text;

            }

            set
            {

                txtEndereco.Text = value;
            }
        }

        public string Cep
        {

            get
            {

                return txtCep.Text;

            }

            set
            {

                txtCep.Text = value;
            }
        }


        public string Telefone

        {

            get
            {

                return txtTelefone.Text;

            }

            set
            {

                txtTelefone.Text = value;
            }
        }


        public string Celular
        {

            get
            {

                return txtCelular.Text;

            }

            set
            {

                txtCelular.Text = value;
            }
        }


        public DateTime? dataNascimento
        {

            get
            {

                return DateTime.Parse(txtDataNascimento.Text);

            }

            set
            {

                txtDataNascimento.Text = value.ToString();
            }
        }
        public DateTime? dataCadastro    { get; set; }
        
        public DateTime? dataAtualizacao { get; set; }
        public AcaoDoObjeto Acao { get; set; }
        public List<AlunoEntity> ListaResultado
        {
            get {

                return Session["ListaResultado"] as List<AlunoEntity>;

            }

            set {

                Session["ListaResultado"] = value;
                CarregaDados();
            }
        }

        public event EventHandler Salvar;
    }
}