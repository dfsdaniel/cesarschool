using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExercicioMasterDetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            masterPage.BtFotos.Clicked += Menu_Clicked;
            masterPage.BtConfig.Clicked += Menu_Clicked;
            masterPage.BtCalendario.Clicked += Menu_Clicked;
        }

        void Menu_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            switch (bt.StyleId)
            {
                case "fotos":
                    this.Detail = new NavigationPage(new FotosPage());
                    break;
                case "calendario":
                    this.Detail = new NavigationPage(new CalendarioPage());
                    break;
                case "config":
                    this.Detail = new NavigationPage(new ConfigPage());
                    break;
                default:
                    this.Detail = new NavigationPage(new FotosPage());
                    break;
            }
            this.IsPresented = false;
        }

    }
}
