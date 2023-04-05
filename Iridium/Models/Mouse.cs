using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iridium.Models {
    internal class Mouse {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);



        public const int MOUSEEVENTF_LEFTDOWN = 0x00000002;
        public const int MOUSEEVENTF_LEFTUP = 0x00000004;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x00000020;
        public const int MOUSEEVENTF_MIDDLEUP = 0x00000040;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x00000008;
        public const int MOUSEEVENTF_RIGHTUP = 0x00000010;


        public static void HoldRightClickDown(int PositionX, int PositionY, bool hold) {
            bool lastHold = false;
            if (hold && hold != lastHold) {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, PositionX, PositionY, 0, 0);
            }
            else if (!hold && hold != lastHold) {
                mouse_event(MOUSEEVENTF_RIGHTUP, PositionX, PositionY, 0, 0);
            }
        }

        public static void LeftClick(int PositionX, int PositionY) {
            SetCursorPos(PositionX, PositionY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, PositionX, PositionY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, PositionX, PositionY, 0, 0);
        }

        public static void RightClick(int PositionX, int PositionY) {
            SetCursorPos(PositionX, PositionY);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, PositionX, PositionY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_RIGHTUP, PositionX, PositionY, 0, 0);
        }

        public static void MiddleClick(int PositionX, int PositionY) {
            SetCursorPos(PositionX, PositionY);
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, PositionX, PositionY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_MIDDLEUP, PositionX, PositionY, 0, 0);
        }
    }
}
