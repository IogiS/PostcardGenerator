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
            elementsTextLabel.Visible = false;
        }

        private void elementsPanel1_DragLeave(object sender, EventArgs e)
        {

        }

        private void elementsPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                
                e.Effect = DragDropEffects.Copy;
                
            }
        }

        private void elementsPanel1_DragDrop(object sender, DragEventArgs e)
        {
            List<string> formats = new List<string> {"png","jpg","jpeg","gif"};
            try
            {
                foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    string format = item.Split('.')[item.Split('.').Count() - 1];
                    for (int i = 0; i < formats.Count; i++)
                    {
                        if (format == formats[i])
                        {
                            picturePanel.BackgroundImage = new Bitmap(item);
                            elementsPicLabel.Visible = false;
                            break;
                        }                        
                    }                    
                    
                    
                }
                if (elementsPicLabel.Visible)
                {
                    throw new FormatException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат\n" + ex);
            }
        }
    }
}
