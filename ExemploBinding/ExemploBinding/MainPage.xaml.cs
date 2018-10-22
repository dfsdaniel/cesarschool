using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label lblNovo = new Label();
            lblNovo.TextColor = Color.Red;

            lblNovo.BindingContext = slider;
            lblNovo.SetBinding(Label.TextProperty, "Value");

            BoxView box = new BoxView();
            box.Color = Color.Green;

            box.SetBinding(BoxView.OpacityProperty, new Binding
            {
                Source = Slider,
                Path = "Value"
            });

            stack.Children.Add(lblNovo);
            stack.Children.Add(box);
        }
    }
}
