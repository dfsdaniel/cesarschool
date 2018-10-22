using System;
using Xamarin.Forms;

namespace SayHello
{
    public class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            Title = "Página 2";
            TextAlignment posicao = TextAlignment.Center;
            if (Device.RuntimePlatform == Device.iOS) {
                posicao = TextAlignment.Start;
            }

            Label texto = new Label
            {
                Text = "ESTA É MINHA NOVA PÁGINA",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = posicao
            };

            Content = texto;
        }
    }
}
