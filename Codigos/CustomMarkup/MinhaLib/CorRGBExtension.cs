using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhaLib
{
    public class CorRGBExtension : IMarkupExtension
    {
        public int R
        {
            get;
            set;
        }

        public int G
        {
            get;
            set;
        }

        public int B
        {
            get;
            set;
        }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgb(R, G, B);
        }
    }
}
