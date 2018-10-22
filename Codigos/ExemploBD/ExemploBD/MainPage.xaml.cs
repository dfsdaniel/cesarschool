using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploBD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CarregarLista();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Aluno novoAluno = new Aluno
            {
                Nome = txtNome.Text,
                Cidade = txtCidade.Text
            };

            App.BD.Insert(novoAluno);

            CarregarLista();
        }

        void CarregarLista() {
            var dadosTabela = App.BD.Table<Aluno>();

            List<Aluno> lista = (from aluno in dadosTabela
                                 orderby aluno.Nome
                                 select aluno).ToList();

            listaAluno.ItemsSource = lista;
        }
    }
}
