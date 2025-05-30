﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vJoyInterfaceWrap;

namespace PedalPal
{
    class VJoy
    {
        Main main;

        vJoy vjoy;
        uint vjoyId;

        public VJoy(Main main, uint vjoyId) { 
            vjoy = new vJoy();

            if (!vjoy.vJoyEnabled())
            {
                Console.WriteLine("vJoy is not enabled!");
            }

            this.main = main;
            this.vjoyId = vjoyId;
            vjoy.AcquireVJD(vjoyId);
        }

        public void SetVJoyAxes(UInt16 brake, UInt16 throttle)
        {
            Int32 vBrake = (brake >> 1);
            Int32 vThrottle = (throttle >> 1);
            vjoy.SetAxis(vBrake, vjoyId, HID_USAGES.HID_USAGE_RX);
            vjoy.SetAxis(vThrottle, vjoyId, HID_USAGES.HID_USAGE_RY);
            main.UpdateRemoteBrake(brake);
            main.UpdateRemoteThrottle(throttle);  
        }
    }
}
