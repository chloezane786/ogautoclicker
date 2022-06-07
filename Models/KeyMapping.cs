﻿using System;
using System.Text.Json.Serialization;

namespace OGAutoClicker.Models
{
    public class KeyMapping
    {
        private string virtualKeyCodeHex;

        public KeyMapping()
        {
        }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("virtual_key_name")]
        public string VirtualKeyName { get; set; }

        [JsonPropertyName("virtual_key_hex_code")]
        public string VirtualKeyHexCode
        {
            get
            {
                return virtualKeyCodeHex;
            }
            set
            {
                virtualKeyCodeHex = value;
                VirtualKeyCode = Convert.ToInt32(virtualKeyCodeHex, 16);
            }
        }

        [JsonPropertyName("virtual_key_code")]
        public int VirtualKeyCode { get; set; }
    }
}
