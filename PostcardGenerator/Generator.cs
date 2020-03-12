using PostcardGenerator.Work;
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

        Events events;
        public Generator()
        {
            InitializeComponent();
            Templates.panels = new List<Panel>() { templatePanel1, templatePanel2, templatePanel3, templatePanel4, templatePanel5 };
            events = new Events(picturePanel, elementsPicLabel, musicPanel, elementsMusicLabel,volumeScroll , textBox1);

        }

        private void Form1_Load(object sender, EventArgs e) => Templates.Load();

        private void panel_DoubleClick(object sender, EventArgs e) => Templates.ApplyTemplate(sender, postcardPanel);      

        private void label1_DoubleClick(object sender, EventArgs e) => elementsTextLabel.Visible = false;

        private void elementsPanel1_DragEnter(object sender, DragEventArgs e) => events.elementsPanels_DragEnterEvent(sender, e);


        private void elementsPanel1_DragDrop(object sender, DragEventArgs e) => events.picturePanel_DragDropEvent(e);

        private void musicPanel_DragDrop(object sender, DragEventArgs e) => events.picturePanel_DragDropEvent(e);

        private void playButton_Click(object sender, EventArgs e) => events.playEvent();

        private void stopButton_Click(object sender, EventArgs e) => events.stopEvent();

        private void volumeScroll_Scroll(object sender, EventArgs e) => events.volumeEvent();
   
        private void button1_Click(object sender, EventArgs e) => events.pauseEvent();

        private void настроитьТекстToolStripMenuItem1_Click(object sender, EventArgs e) => events.showTextSettings();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextSettings.changed)
            {
                textBox1.Font = TextSettings.font;
                textBox1.ForeColor = TextSettings.color;
                TextSettings.changed = false;
            }
        }

        private void textBox1_ContextMenuStripChanged(object sender, EventArgs e)
        {
           
        }
    }
}
