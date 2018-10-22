using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ExercicioLabelCores
{
    public partial class ExibeCor : ContentView
    {
        public string NomeCor
        {
            get {
                return lblNomeCor.Text;
            }
            set {
                lblNomeCor.Text = value;

                ColorTypeConverter conversor = new ColorTypeConverter();
                Color cor = (Color) conversor.ConvertFromInvariantString(value);

                box.Color = cor;

                lblHexa.Text = String.Format("{0:X2} - {1:X2} - {2:X2}",
                                             (int)cor.R * 255,
                                             (int)cor.G * 255,
                                             (int)cor.B * 255);
            }
        }

        public ExibeCor()
        {
            InitializeComponent();
        }
    }
}
