using System;
using Xamarin.Forms;

namespace SayHello
{
    public class Pagina1 : ContentPage
    {
        void BtPagina2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina2());
        }

        public Pagina1()
        {
            Title = "Página 1";

            Button btPagina2 = new Button();
           btPagina2.Text = "Ir para página 2";
                btPagina2.Clicked += BtPagina2_Clicked;

                Content = new StackLayout
            {
                Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Bem vindos ao Xamarin do CESAR School",
                    },
                    btPagina2
                },
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}
