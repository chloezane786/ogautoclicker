using System;
using OGAutoClicker.Enums;

namespace OGAutoClicker.Models
{
    public class SystemTrayMenuActionEventArgs : EventArgs
    {
        public SystemTrayMenuAction Action { get; set; }
    }
}
