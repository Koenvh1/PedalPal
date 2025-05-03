using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedalPal
{
    public partial class Main : Form
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, String pszSubAppName, String pszSubIdList);


        private SimpleJoystick simpleJoystick;
        private Networking networking;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (networking != null)
            {
                networking.Destroy();
            }
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            simpleJoystick = new SimpleJoystick();
      
            var storedIndex = -1;
            for (int i = 0; i < simpleJoystick.GetDevices().Count; i++) 
            {
                comboDevice.Items.Add(simpleJoystick.GetDevices()[i].InstanceName);
                if (simpleJoystick.GetDevices()[i].InstanceGuid.ToString() == Properties.Settings.Default.Joystick)
                {
                    storedIndex = i;
                }
            }
            if (storedIndex >= 0)
            {
                comboDevice.SelectedIndex = storedIndex;
            }

            comboBrake.SelectedIndex = comboBrake.FindStringExact(Properties.Settings.Default.Brake);
            comboThrottle.SelectedIndex = comboThrottle.FindStringExact(Properties.Settings.Default.Throttle);

            inputIP.Text = Properties.Settings.Default.IP;

            comboVJoyID.SelectedIndex = comboVJoyID.FindStringExact(Properties.Settings.Default.VJoyID.ToString());

            progressBrake.Minimum = UInt16.MinValue;
            progressBrake.Maximum = UInt16.MaxValue;
            SetWindowTheme(progressBrake.Handle, " ", " ");
            progressThrottle.Minimum = UInt16.MinValue;
            progressThrottle.Maximum = UInt16.MaxValue;
            SetWindowTheme(progressThrottle.Handle, " ", " ");
            progressBrakeRemote.Minimum = UInt16.MinValue;
            progressBrakeRemote.Maximum = UInt16.MaxValue;
            SetWindowTheme(progressBrakeRemote.Handle, " ", " ");
            progressThrottleRemote.Minimum = UInt16.MinValue;
            progressThrottleRemote.Maximum = UInt16.MaxValue;
            SetWindowTheme(progressThrottleRemote.Handle, " ", " ");

            Networking.GetPublicIP().ContinueWith(t =>
            {
                if (t.IsCompleted)
                {
                    UpdateOwnIP(t.Result);
                }
            });
        }

        private void UpdateOwnIP(string text)
        {
            if (inputOwnIP.InvokeRequired)
            {
                inputOwnIP.Invoke(new Action(() => UpdateOwnIP(text)));
            }
            else
            {
                inputOwnIP.Text = text;
            }
        }

        public void UpdateRemoteBrake(UInt16 brake)
        {
            if (progressBrakeRemote.InvokeRequired)
            {
                progressBrakeRemote.Invoke(new Action(() => UpdateRemoteBrake(brake)));
            }
            else
            {
                progressBrakeRemote.Value = brake;
            }
        }

        public void UpdateRemoteThrottle(UInt16 throttle)
        {
            if (progressThrottleRemote.InvokeRequired)
            {
                progressThrottleRemote.Invoke(new Action(() => UpdateRemoteThrottle(throttle)));
            }
            else
            {
                progressThrottleRemote.Value = throttle;
            }
        }

        private void comboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var device = simpleJoystick.GetDevices()[comboDevice.SelectedIndex];
            Properties.Settings.Default.Joystick = device.InstanceGuid.ToString();
            Properties.Settings.Default.Save();

            simpleJoystick.Acquire(device.InstanceGuid);
        }

        private void inputTimer_Tick(object sender, EventArgs e)
        {
            var joystick = simpleJoystick.GetJoystick();
            if (joystick != null)
            {
                joystick.Poll();
                var state = joystick.GetCurrentState();

                var brake = SimpleJoystick.GetJoystickState(comboBrake.Text, state);
                var brake_u16 = Convert.ToUInt16(brake);
                progressBrake.Value = brake;
                var throttle = SimpleJoystick.GetJoystickState(comboThrottle.Text, state);
                var throttle_u16 = Convert.ToUInt16(throttle);
                progressThrottle.Value = throttle;

                if (networking != null) networking.SendData(brake_u16, throttle_u16);
                //Console.WriteLine(state.ToString()); 
            }
        }

        private void comboBrake_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Brake = comboBrake.Text;
            Properties.Settings.Default.Save();
        }

        private void comboThrottle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Throttle = comboThrottle.Text;
            Properties.Settings.Default.Save();
        }

        private void inputIP_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = inputIP.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var vjoy = new VJoy(this, Convert.ToUInt32(comboVJoyID.Text));
            if (networking != null)
            {
                networking.Destroy();
            }
            networking = new Networking(vjoy, inputIP.Text);
        }

        private void comboVJoyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VJoyID = Convert.ToInt32(comboVJoyID.Text);
            Properties.Settings.Default.Save();
        }

        private void linkGameControllers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL joy.cpl");
        }
    }
}
