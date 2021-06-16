using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text;

namespace C3_Education
{
    class Program
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString
           (string mciCommand,
           StringBuilder returnValue,
           int returnLength,
           IntPtr callback);

        static void Main(string[] args)
        {
            a:
            int result = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            Thread.Sleep(1000);
            result = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
            Thread.Sleep(1000);
            goto a;
        }
    }
}
