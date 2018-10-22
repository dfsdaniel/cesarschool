using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExercicioBrowser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            areaBrowser.Source = txtUrl.Text;
        }

        void BtVoltar_Clicked(object sender, System.EventArgs e)
        {
            areaBrowser.GoBack();
        }

        void BtAvancar_Clicked(object sender, System.EventArgs e)
        {
            areaBrowser.GoForward();
        }
    }
}
