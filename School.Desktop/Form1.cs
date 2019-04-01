using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.Entity;
using Cadastro.Presenter;

namespace School.Desktop
{
    public partial class Form1 : Form ,  Cadastro.Interface.IViewAlunos
    {

        AlunoPresenter presenter;
        public Form1()
        {
            InitializeComponent();
            presenter = new AlunoPresenter(this);
        }

        public string Nome
        {
            get {

                return txtNome.Text;
            }

            set
            {
                txtNome.Text = value;
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
                if ( string.IsNullOrEmpty(txtDataNascimento.Text))
                {
                    return DateTime.MinValue;
                }
                return DateTime.Parse(txtDataNascimento.Text);

            }

            set
            {
                txtDataNascimento.Text = value.ToString();
            }
        }
        public DateTime? dataCadastro { get ; set ; }
        public DateTime? dataAtualizacao { get ; set ; }
        public AcaoDoObjeto Acao { get ; set ; }
        public List<AlunoEntity> ListaResultado { get ; set ; }

        public event EventHandler Salvar;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(sender, e);
        }
    }
}
