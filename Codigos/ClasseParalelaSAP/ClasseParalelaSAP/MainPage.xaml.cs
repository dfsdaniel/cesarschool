using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClasseParalelaSAP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SOInfo info = new SOInfo();
            lblInfo.Text = info.GetInfo();
        }
    }
}
