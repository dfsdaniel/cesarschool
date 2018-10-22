using System;
using Xamarin.Forms;

namespace ExemploBotao
{
	public class MainPage : ContentPage
    {
        void Bt_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt == btAdicionar) {
                Label labelDataHora = new Label
                {
                    Text = DateTime.Now.ToLongTimeString()
                };
                stackFilho.Children.Add(labelDataHora);    
            } else {
                stackFilho.Children.RemoveAt(0);
            }

            btRemover.IsEnabled = stackFilho.Children.Count > 0;
        }

        StackLayout stackFilho;
        Button btAdicionar, btRemover;

        public MainPage()
        {            
            btAdicionar = new Button
            {
                Text = "Adicionar",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            btRemover = new Button
            {
                Text = "Remover",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                IsEnabled = false
            };

            StackLayout stackBotoes = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    btAdicionar, btRemover
                }
            };

            stackFilho = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            //btAdicionar.Clicked += (object sender, EventArgs e) => {
            //    Label labelDataHora = new Label
            //    {
            //        Text = DateTime.Now.ToLongTimeString()
            //    };
            //    stackFilho.Children.Add(labelDataHora);
            //};

            btAdicionar.Clicked += Bt_Clicked;
            btRemover.Clicked += Bt_Clicked;

            Content = new StackLayout
            {
                Children = {
                    stackBotoes,
                    stackFilho
                }
            };
            Padding = 20;
        }
    }
}
