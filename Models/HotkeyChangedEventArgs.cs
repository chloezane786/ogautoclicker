using System;
using OGAutoClicker.Enums;

namespace OGAutoClicker.Models
{
    public class HotkeyChangedEventArgs : EventArgs
    {
        public KeyMapping Hotkey { get; set; }
        public Operation Operation { get; set; }
    }
}
