using System;
using Xamarin.Forms;

namespace ExercicioTexto
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Label texto = new Label();
            texto.VerticalOptions = LayoutOptions.Center;
            texto.HorizontalOptions = LayoutOptions.Center;
            texto.HorizontalTextAlignment = TextAlignment.Center;

            texto.FormattedText = new FormattedString
            {
                Spans = {
                    new Span
                    {
                        Text = "Este curso de"
                    },
                    new Span
                    {
                        Text = " Desenvolvimento com Xamarin",
                        FontAttributes = FontAttributes.Bold,
                        ForegroundColor = Color.Red
                    },
                    new Span
                    {
                        Text = " é muito bacana",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Italic
                    }
                }
            };

            this.Content = texto;
            this.Padding = 30;
        }
    }
}
