using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ExemploCustomXAML
{
    public partial class Contato : ContentView
    {
        public Contato()
        {
            InitializeComponent();
        }

        public string Nome
        {
            get {
                return lblNome.Text;
            }
            set {
                lblNome.Text = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return lblSobrenome.Text;
            }
            set
            {
                lblSobrenome.Text = value;
            }
        }
    }
}
