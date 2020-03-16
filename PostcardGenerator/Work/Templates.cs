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
       public static List<Panel> templatePanels = new List<Panel>();
        public static List<Panel> postcardPanels = new List<Panel>();
        public static List<Label> postcardLabelss = new List<Label>();
        public static List<Image> images = new List<Image>();

        public static void Load()
        {
            string path = "../../images";
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                images.Add(new Bitmap(files[i]));
                templatePanels[i].BackgroundImage = images[i];
            }
        }

        public static void ApplyTemplate(object sender,Panel postcardPanel)
        {
            for (int i = 0; i < images.Count; i++)
            {
                if (templatePanels[i].Name == ((Panel)sender).Name)
                {
                    postcardPanel.BackgroundImage = templatePanels[i].BackgroundImage;
                    
                }

            }
        }
    }
}
