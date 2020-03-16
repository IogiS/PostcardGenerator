﻿using PostcardGenerator.Properties;
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
using Newtonsoft.Json;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows;

namespace PostcardGenerator
{
    public partial class Generator : Form
    {
        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
        GeneratorEvents events;
        public bool addPressed { get; set; }
        public bool delPressed { get; set; }
        public Generator()
        {
            InitializeComponent();
            Templates.templatePanels = new List<Panel>() { templatePanel1, templatePanel2, templatePanel3, templatePanel4, templatePanel5 };
            Templates.postcardPanels = new List<Panel>() {bottomLeftPanel, topCenterPanel, topLeftPanel, topRightPanel,
                                                           bottomRightPanel,bottomCenterPanel,centerRightPanel,midleCenterPanel,midleLeftPanel };
            Templates.postcardLabelss = new List<Label>() {bottomLeftLabel,topMiddleLabel,topLeftLabel,topRightLabel,bottomRightLabel,
                                                           bottomMiddleLabel,MiddleRightLabel,centerMiddleLabel, centerLeftLabel};
            events = new GeneratorEvents(picturePanel, elementsPicLabel, musicPanel, elementsMusicLabel, volumeScroll, textBox1);

        }

        private void Form1_Load(object sender, EventArgs e) => Templates.Load();

        private void panel_DoubleClick(object sender, EventArgs e) => Templates.ApplyTemplate(sender, postcardPanel);

        private void label1_DoubleClick(object sender, EventArgs e) => elementsTextLabel.Visible = false;

        private void elementsPanel1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) => events.elementsPanels_DragEnterEvent(sender, e);


        private void elementsPanel1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) => events.picturePanel_DragDropEvent(sender, e);

        private void musicPanel_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) => events.picturePanel_DragDropEvent(sender, e);

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


        private void saveButton_Click(object sender, EventArgs e)
        {
            searchImagesInPanels();
            //Save();
        }

        private void Save()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files(*.json)|*.json";
            ofd.ShowDialog();

            string path = ofd.FileName;

            SavingSettings setting = new SavingSettings() { SettingName = "Tom", SettingValue = "35", SettingImage = postcardPanel.BackgroundImage.Clone() };

            List<SavingSettings> savingSettings = new List<SavingSettings>();
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(setting));






            elementsPicLabel.Visible = false;

        }


        public void searchImagesInPanels()
        {
            Image mainImage = postcardPanel.BackgroundImage;
            mainImage = ResizeImage(mainImage, postcardPanel.Width, postcardPanel.Height);
            Graphics g = Graphics.FromImage(mainImage);
            for (int i = 0; i < Templates.postcardPanels.Count(); i++)
            {
                if (Templates.postcardPanels[i].BackgroundImage != null)
                {
                    Image background = Templates.postcardPanels[i].BackgroundImage;
                    g.DrawImage(ResizeImage(background, Templates.postcardPanels[i].Size.Width, Templates.postcardPanels[i].Size.Height),
                        Templates.postcardPanels[i].Location.X, Templates.postcardPanels[i].Location.Y);


                }
                if (Templates.postcardLabelss[i].Text != null)
                {
                    Font drawFont = new Font("Arial", 16);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    g.DrawString(Templates.postcardLabelss[i].Text, drawFont, drawBrush, Templates.postcardPanels[i].Location.X, Templates.postcardPanels[i].Location.Y);

                }
            }
            mainImage.Save(@"C:\Users\LogiS\Desktop\main.png", ImageFormat.Png);
        }

        private void topRightPanel_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) => events.picturePanel_DragDropEvent(sender, e);



        private void topRightPanel_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) => events.elementsPanels_DragEnterEvent(sender, e);

        private void openProjektButton_Click(object sender, EventArgs e)
        {
            
        }




        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        private void topMiddleLabel_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                events.TextFormat((Label)sender, add.Checked);

            }
        }

        private void del_CheckedChanged(object sender, EventArgs e)
        {

            ToolStripMenuItem tlm = (sender) as ToolStripMenuItem;
            add.Checked = !tlm.Checked;
        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem tlm = (sender) as ToolStripMenuItem;
            del.Checked = !tlm.Checked;
        }
    }




}
