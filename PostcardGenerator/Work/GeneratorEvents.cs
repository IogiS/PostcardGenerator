﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PostcardGenerator.Work
{
    public class GeneratorEvents : IEvents
    {

        Panel elementPanel { get; set; }
         Panel musicPanel { get; set; }
         Label elementLabel { get; set; }
         Label elementsMusicLabel { get; set; }
         TrackBar volumeScroll { get; set; }
         TextBox textBox { get; set; }

        public GeneratorEvents(Panel elementPanel, Label elementLabel, Panel musicPanel, Label elementsMusicLabel, TrackBar volumeScroll, TextBox textBox)
        {
            this.elementPanel = elementPanel;
            this.musicPanel = musicPanel;
            this.elementLabel = elementLabel;
            this.elementsMusicLabel = elementsMusicLabel;
            this.volumeScroll = volumeScroll;
            this.textBox = textBox;
        }
  
        public void picturePanel_DragDropEvent(object sender,DragEventArgs e)
        {           
            try
            {
                List<string> imageFormats = new List<string> { "png", "jpg", "jpeg", "gif" };
                List<string> musicFormats = new List<string> { "mp3", "avi", "wav", "mp4" };
                var a = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var path in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    string format = path.Split('.')[path.Split('.').Count() - 1];

                    for (int i = 0; i < 4; i++)
                    {
                        if (format == imageFormats[i])
                        {
                            ImageFormat((Panel)sender,path);
                            break;
                        }
                        if (musicFormats[i] == format)
                        {
                            MusicFormat(path);
                            break;
                        }
                    }


                }
                if (elementLabel.Visible && MusicSettings.mediaPlayer.Source == null)
                {
                    throw new FormatException();
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void elementsPanels_DragEnterEvent(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        public void TextFormat(Label sender, bool pressed)
        {
            sender.ForeColor = TextSettings.color;
            sender.Font = TextSettings.font;
            if (pressed)          
                sender.Text = textBox.Text;
            else
                sender.Text = null;
        }

        private void ImageFormat(Panel sender,string path)
        {
            
            sender.BackgroundImage = new Bitmap(path);
            elementLabel.Visible = false;           
        }

        private void MusicFormat(string path)
        {

            MusicSettings.AddNewSong(path);
            MusicSettings.Play();
            elementsMusicLabel.Text = path.Split('\\')[path.Split('\\').Length - 1].ToString();
        }

        public void playEvent() => MusicSettings.Play();

        public void stopEvent() => MusicSettings.Stop();

        public void volumeEvent() => MusicSettings.ChangeVolume((double)volumeScroll.Value / 100);

        public void pauseEvent() => MusicSettings.Pause();

        public void showTextSettings()
        {
            TextSetting textSetting = new TextSetting();
            textSetting.Show();
        }

        public void CloseForm(Form g)
        {
            CloseForm(g);
        }
    }
}
