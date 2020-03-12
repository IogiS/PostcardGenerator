using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostcardGenerator
{
    public static class TextSettings
    {
        public  static Font font { get; set; }

        public static Size size { get; set; }

        public static Color color { get; set; }

        public static bool changed { get; set; }

        public static  void LoadFonts(ComboBox fontComboBox)
        {
            
            foreach (FontFamily font in FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name.ToString());
            }
        }

        public static void LoadSizes(ComboBox fontComboBox)
        {

            foreach (FontFamily font in FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name.ToString());
            }
        }
    }
}
