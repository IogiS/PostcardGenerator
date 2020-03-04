using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostcardGenerator
{
    public partial class Generator : Form
    {


        public Generator()
        {
            InitializeComponent();
            Templates.panels = new List<Panel>() { panel1, panel2, panel3, panel4, panel5 };
        }

        private void Form1_Load(object sender, EventArgs e) => Templates.Load();



        private void panel_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < Templates.images.Count; i++)
            {
                if (Templates.panels[i].Name == ((Panel)sender).Name)
                {
                    postcardPanel.BackgroundImage = Templates.panels[i].BackgroundImage;
                }
                
            }

        }
    }
}
