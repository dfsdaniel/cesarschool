using System;
using UIKit;

namespace ClasseParalelaSAP
{
    public class SOInfo
    {
        public string GetInfo() {
            UIDevice device = new UIDevice();
            return device.Model;
        }
    }
}
