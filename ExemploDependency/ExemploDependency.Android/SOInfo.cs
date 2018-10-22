using System;
using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploDependency.Android.SOInfo))]
 
namespace ExemploDependency.Android
{
    public class SOInfo : ISOInfo
    {
        public string GetInfo() {
            return Build.Manufacturer;
        }
    }
}
