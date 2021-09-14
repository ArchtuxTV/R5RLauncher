using R5RLauncher.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R5RLauncher
{
    class Helpers
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            /// <summary>
            /// User defined data to be passed to the receiving application.
            /// </summary>
            public IntPtr dwData;

            /// <summary>
            /// The size, in bytes, of the data pointed to by the lpData member.
            /// </summary>
            public int cbData;

            /// <summary>
            /// The data to be passed to the receiving application. This member can be IntPtr.Zero.
            /// </summary>
            public IntPtr lpData;
        }

        public static uint WM_COPYDATA = 0x004A;

        public async static void ServerConnect(string ip, string port, string key)
        {
            Process[] processes = Process.GetProcessesByName("r5apex");

            if (File.ReadAllText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg").Contains("-dev"))
            {
                //File Good
            }
            else
            {
                using (StreamWriter sw = File.AppendText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg"))
                {
                    sw.WriteLine("\n-dev");
                }
            }


            if (processes.Length == 0)
            {

                await Task.Delay(10000);

                string m_pTestCommand = "launcherconnect" + " " + ip + " " + port + " " + key;

                IntPtr m_hEngine = FindWindow("Respawn001", null);

                COPYDATASTRUCT m_cData;
                m_cData.cbData = m_pTestCommand.Length + 1;
                m_cData.dwData = IntPtr.Zero;
                m_cData.lpData = Marshal.StringToHGlobalAnsi(m_pTestCommand);

                // Allocate memory for the data and copy
                IntPtr ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(m_cData));
                Marshal.StructureToPtr(m_cData, ptrCopyData, false);

                SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);

            }
            else
            {
                string m_pTestCommand = "launcherconnect" + " " + ip + " " + port + " " + key;

                IntPtr m_hEngine = FindWindow("Respawn001", null);

                COPYDATASTRUCT m_cData;
                m_cData.cbData = m_pTestCommand.Length + 1;
                m_cData.dwData = IntPtr.Zero;
                m_cData.lpData = Marshal.StringToHGlobalAnsi(m_pTestCommand);

                // Allocate memory for the data and copy
                IntPtr ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(m_cData));
                Marshal.StructureToPtr(m_cData, ptrCopyData, false);

                SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);

            }
        }

        public async static void StartServer(string vis, string key, string name)
        {
            Process[] processes = Process.GetProcessesByName("r5apex");

            if (File.ReadAllText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg").Contains("-dev"))
            {
                //File Good
            }
            else
            {
                using (StreamWriter sw = File.AppendText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg"))
                {
                    sw.WriteLine("\n-dev");
                }
            }

            string newname = name.Replace(" ", "=");

            //WHAT THE FUCK 8 HOURS FOR THIS SHIT
            WHYDOINEEDTODOTHISWTF();

            await Task.Delay(1000);

            if (processes.Length > 0)
            {

                string m_pTestCommand = "createserver" + " " + key + " " + newname + " " + vis;

                IntPtr m_hEngine = FindWindow("Respawn001", null);

                COPYDATASTRUCT m_cData;
                m_cData.cbData = m_pTestCommand.Length + 1;
                m_cData.dwData = IntPtr.Zero;
                m_cData.lpData = Marshal.StringToHGlobalAnsi(m_pTestCommand);

                // Allocate memory for the data and copy
                IntPtr ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(m_cData));
                Marshal.StructureToPtr(m_cData, ptrCopyData, false);

                SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);

            }
        }

        private async static void WHYDOINEEDTODOTHISWTF()
        {
            Process[] processes = Process.GetProcessesByName("r5apex");

            if (processes.Length > 0)
            {

                string m_pTestCommand = "ccompanion";

                IntPtr m_hEngine = FindWindow("Respawn001", null);

                COPYDATASTRUCT m_cData;
                m_cData.cbData = m_pTestCommand.Length + 1;
                m_cData.dwData = IntPtr.Zero;
                m_cData.lpData = Marshal.StringToHGlobalAnsi(m_pTestCommand);

                // Allocate memory for the data and copy
                IntPtr ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(m_cData));
                Marshal.StructureToPtr(m_cData, ptrCopyData, false);

                SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);
                await Task.Delay(100);
                SendMessage(m_hEngine, WM_COPYDATA, IntPtr.Zero, ptrCopyData);
            }
        }

        public static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        public static event EventHandler ProcessClosed;

        public static void MonitorForExit(Process process)
        {
            Thread thread = new Thread(() =>
            {
                process.WaitForExit();
                OnProcessClosed(EventArgs.Empty);
            });
            thread.Start();
        }

        private static void OnProcessClosed(EventArgs d)
        {
            if (ProcessClosed != null)
            {
                ProcessClosed(null, d);
            }
        }
    }
}
