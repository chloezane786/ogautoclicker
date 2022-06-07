using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace OGAutoClicker.Views
{
    public class WinApi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

            [DllImport("user32.dll")]
            public static extern int GetAsyncKeyState(int character);

            [DllImport("user32.dll")]
            public static extern int SetCursorPos(int x, int y);

            // Get custom coords
            [DllImport("user32.dll")]
            public static extern bool GetCursorPos(out POINT lpPoint);

            public static Point GetCursorPosition()
            {
                POINT lpPoint;
                GetCursorPos(out lpPoint);
                return lpPoint;
            }
        
    }
}
