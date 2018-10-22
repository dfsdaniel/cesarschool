using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ExercicioTeclado
{
    public class MainPage : ContentPage
    {
        const string chaveTeclado = "chaveTeclado";

        StackLayout layout = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };

        Label display = new Label
        {
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            HorizontalTextAlignment = TextAlignment.End
        };

        Button btApagar = new Button
        {
            Text = "\u21E6",
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            StyleId = "apagar"
        };

        public MainPage()
        {
            btApagar.Clicked += BtDigito_Clicked;

            layout.Children.Add(display);
            layout.Children.Add(btApagar);

            StackLayout linha = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            layout.Children.Add(linha);

            for (int i = 0; i <= 9; i++)
            {
                Button btDigito = new Button
                {
                    Text = i.ToString(),
                    StyleId = i.ToString(),
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };
                btDigito.Clicked += BtDigito_Clicked;

                linha.Children.Add(btDigito);

                if (i % 3 == 0) {
                    linha = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    };
                    layout.Children.Add(linha);
                }
            }

            this.Content = layout;

            IDictionary<string, object> localStorage = Application.Current.Properties;

            if (localStorage.ContainsKey(chaveTeclado)) {
                display.Text = localStorage[chaveTeclado].ToString();
            }
        }

        void BtDigito_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt.StyleId == "apagar") {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            } else {
                display.Text += bt.StyleId;
            }

            Application.Current.Properties[chaveTeclado] = display.Text;
        }

    }
}
