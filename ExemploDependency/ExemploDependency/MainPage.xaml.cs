using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploDependency
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            lblInfo.Text = DependencyService.Get<ISOInfo>().GetInfo();
        }
    }
}
