using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardGenerator.Work
{
    class SavingSettings
    {
        public string ElementName { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public Font Font { get; set; }
        public Color Color { get; set; }

        public byte[] SettingImage { get; set; }

    }
}
