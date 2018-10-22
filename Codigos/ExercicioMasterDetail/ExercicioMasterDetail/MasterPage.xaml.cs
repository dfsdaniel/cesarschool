using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExercicioMasterDetail
{
    public partial class MasterPage : ContentPage
    {
        public Button BtFotos
        {
            get {
                return btFotos;
            }
        }

        public Button BtCalendario
        {
            get
            {
                return btCalendario;
            }
        }

        public Button BtConfig
        {
            get
            {
                return btConfig;
            }
        }

        public MasterPage()
        {
            InitializeComponent();
        }
    }
}
