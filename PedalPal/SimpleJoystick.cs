/*
 * Simple Joystick API
 *    Coded by Chris Seto 2010
 *    
 * This code released under the Apache 2.0 license, copyright Chris Seto 2010
 * 
 * https://www.ghielectronics.com/community/forum/topic?id=1296&page=2#msg13766
 * */
using System;
using System.Collections.Generic;
using SharpDX.DirectInput;

namespace PedalPal
{
    class SimpleJoystick
    {
        private DirectInput directInput;
        private List<DeviceInstance> devices = new List<DeviceInstance>();
        private Joystick joystick;

        public SimpleJoystick()
        {
            directInput = new DirectInput();

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                devices.Add(deviceInstance);
            }

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                devices.Add(deviceInstance);
            }

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Driving, DeviceEnumerationFlags.AllDevices))
            {
                devices.Add(deviceInstance);
            }
        }

        public Joystick Acquire(Guid instance)
        {
            var joystick = new Joystick(directInput, instance);
            joystick.Properties.BufferSize = 128;
            joystick.Acquire();
            this.joystick = joystick;
            return joystick;
        }

        public List<DeviceInstance> GetDevices()
        {
            return devices;
        }

        public Joystick GetJoystick()
        {
            return joystick;
        }

        public static int GetJoystickState(string input, JoystickState state)
        {
            switch (input.ToLower())
            {
                case "x":
                    return state.X;
                case "y":
                    return state.Y;
                case "z":
                    return state.Z;
                case "rx":
                case "rotationx":
                    return state.RotationX;
                case "ry":
                case "rotationy":
                    return state.RotationY;
                case "rz":
                case "rotationz":
                    return state.RotationZ;
                case "slider0":
                    return state.Sliders.Length > 0 ? state.Sliders[0] : 0;
                case "slider1":
                    return state.Sliders.Length > 1 ? state.Sliders[1] : 0;
                case "pov0":
                    return state.PointOfViewControllers.Length > 0 ? state.PointOfViewControllers[0] : -1;
                case "pov1":
                    return state.PointOfViewControllers.Length > 1 ? state.PointOfViewControllers[1] : -1;
                default:
                    return 0;
            }
        }
    }
}