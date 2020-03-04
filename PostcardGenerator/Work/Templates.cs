using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostcardGenerator
{
    static class Templates
    {
       public static List<Panel> panels = new List<Panel>();
       public static List<Image> images = new List<Image>();

        public static void Load()
        {
            string path = "../../images";
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                images.Add(new Bitmap(files[i]));
                panels[i].BackgroundImage = images[i];
            }
        }
    }
}
