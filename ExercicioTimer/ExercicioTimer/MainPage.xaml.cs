using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExercicioTimer
{
    public partial class MainPage : ContentPage
    {
        bool isRunning = false;

        public MainPage()
        {
            InitializeComponent();

            lblHora.Text = DateTime.Now.ToString("T");
            lblData.Text = DateTime.Now.ToString("D");

            Device.StartTimer(TimeSpan.FromSeconds(1), HandleFunc);
        }

        void btTimerClicked(object sender, System.EventArgs e)
        {
            isRunning = !isRunning;
            btTimer.Text = isRunning ? "Stop" : "Start";
        }

        bool HandleFunc()
        {
            if (isRunning)
            {
                lblHora.Text = DateTime.Now.ToString("T");
            }
            return true;
        }

    }
}
