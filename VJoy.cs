using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vJoyInterfaceWrap;

namespace PedalPal
{
    class VJoy
    {

        vJoy vjoy;
        uint vjoyId;

        public VJoy() { 
            vjoy = new vJoy();

            if (!vjoy.vJoyEnabled())
            {
                Console.WriteLine("vJoy is not enabled!");
            }

            vjoyId = 1;
            vjoy.AcquireVJD(vjoyId);
        }

        public void SetVJoyAxes(UInt16 brake, UInt16 throttle)
        {
            vjoy.SetAxis(brake, vjoyId, HID_USAGES.HID_USAGE_RX);
            vjoy.SetAxis(throttle, vjoyId, HID_USAGES.HID_USAGE_RY);
        }
    }
}
