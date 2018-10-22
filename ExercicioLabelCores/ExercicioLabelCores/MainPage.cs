using System;
using Xamarin.Forms;
using System.Reflection;

namespace ExercicioLabelCores
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout layout = new StackLayout
            {
                Spacing = 10,
                Padding = 20
            };

            foreach (FieldInfo item in typeof(Color).GetRuntimeFields())
            {
                if (item.IsPublic &&
                    item.IsStatic &&
                    item.FieldType == typeof(Color)) {

                    layout.Children.Add(new ExibeCor {
                        NomeCor = item.Name
                    });
                }
            }

            ScrollView scroll = new ScrollView();
            scroll.Content = layout;

            this.Content = scroll;
        }
    }
}
