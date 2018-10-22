using System;
using Android.OS;

namespace Xablau
{
    public class SOInfo
    {
        public static string GetInfo() {
            return String.Format("SO={0}, Modelo={1}, Versao={2}",
                                 Build.Manufacturer, Build.Model,
                                 Build.VERSION.Release.ToString());
        }
    }
}
