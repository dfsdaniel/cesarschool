using System;
using Android.OS;

namespace ExemploSAP
{
    public class SOInfo
    {
        public static string GetInfo() {
            return String.Format("Modelo={0}, Sistema={1}, Versão={2}",
                                         Build.Manufacturer, Build.Model,
                                         Build.VERSION.Release.ToString());
        }
    }
}
