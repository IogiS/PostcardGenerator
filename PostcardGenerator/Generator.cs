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
            Templates.panels = new List<Panel>() { templatePanel1, templatePanel2, templatePanel3, templatePanel4, templatePanel5 };
        }

        private void Form1_Load(object sender, EventArgs e) => Templates.Load();



        private void panel_DoubleClick(object sender, EventArgs e)
        {
            Templates.ApplyTemplate(sender, postcardPanel);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
