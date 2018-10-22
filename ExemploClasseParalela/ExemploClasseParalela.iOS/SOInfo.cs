using System;
using UIKit;

namespace Xablau
{
    public class SOInfo
    {
        public static string GetInfo()
        {
            UIDevice device = new UIDevice();

            return String.Format("SO={0}, Modelo={1}, Versao={2}",
                                 device.SystemName, device.Model,
                                 device.SystemVersion);
        }
    }
}
