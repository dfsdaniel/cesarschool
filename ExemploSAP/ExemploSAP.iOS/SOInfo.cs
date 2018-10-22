using System;
using UIKit;

namespace ExemploSAP
{
    public class SOInfo
    {
        public static string GetInfo()
        {
            UIDevice device = new UIDevice();

            return String.Format("Modelo={0}, Sistema={1}, Versão={2}", 
                device.Model, device.SystemName, device.SystemVersion);             
        }
    }
}
