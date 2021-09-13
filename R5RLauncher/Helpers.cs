using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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


            if (processes.Length == 0)
            {

                /*if (File.ReadAllText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg").Contains("-dev"))
                {
                    //File Good
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(Settings.Default.GamePath + "/platform/cfg/startup_retail.cfg"))
                    {
                        sw.WriteLine("\n-dev");
                    }
                }*/

                /*Process p = new Process();
                p.StartInfo.WorkingDirectory = Settings.Default.GamePath;
                p.StartInfo.FileName = Settings.Default.GamePath + "\\Run R5 Reloaded.exe";
                p.StartInfo.Arguments = "-release";
                p.Start();*/

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

        public static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
    }
}
