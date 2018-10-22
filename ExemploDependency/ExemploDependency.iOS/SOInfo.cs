using System;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploDependency.iOS.SOInfo))]

namespace ExemploDependency.iOS
{
    public class SOInfo : ISOInfo
    {
        public string GetInfo() {
            UIDevice device = new UIDevice();
            return device.Model;
        }
    }
}
