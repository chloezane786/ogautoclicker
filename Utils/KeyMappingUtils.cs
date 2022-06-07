using System;
using System.Collections.Generic;
using System.IO;
using OGAutoClicker.Models;

namespace OGAutoClicker.Utils
{
    public static class KeyMappingUtils
    {
        //private static readonly string keysMappingPath;

        public static List<KeyMapping> KeyMapping { get; set; }

        static KeyMappingUtils()
        {
            LoadMapping();
        }

        private static void LoadMapping()
        {
            if (KeyMapping == null)
            {
                ReadMapping();
            }
        }

        public static KeyMapping GetKeyMappingByCode(int virtualKeyCode)
        {
            return KeyMapping.Find(keyMapping => keyMapping.VirtualKeyCode == virtualKeyCode);
        }

        private static void ReadMapping()
        {
            string path = Path.Combine(Path.GetTempPath(), "keyMappings.json");
            File.WriteAllBytes(path, OGAutoClicker.Properties.Resources.keyMappings);
            KeyMapping = JsonUtils.ReadJson<List<KeyMapping>>(path);
        }
    }
}
