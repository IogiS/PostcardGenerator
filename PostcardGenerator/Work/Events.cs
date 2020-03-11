using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;

namespace PostcardGenerator.Work
{
    public class Events : IEvents
    {
        Panel elementPanel, musicPanel;
        Label elementLabel, elementsMusicLabel;
        TrackBar volumeScroll;


        public Events(Panel elementPanel, Label elementLabel, Panel musicPanel, Label elementsMusicLabel, TrackBar volumeScroll)
        {
            this.elementPanel = elementPanel;
            this.musicPanel = musicPanel;
            this.elementLabel = elementLabel;
            this.elementsMusicLabel = elementsMusicLabel;
            this.volumeScroll = volumeScroll;
        }

        public void picturePanel_DragDropEvent(DragEventArgs e)
        {           
            try
            {
                List<string> imageFormats = new List<string> { "png", "jpg", "jpeg", "gif" };
                List<string> musicFormats = new List<string> { "mp3", "avi", "wav", "mp4" };

                foreach (var path in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    string format = path.Split('.')[path.Split('.').Count() - 1];

                    for (int i = 0; i < 4; i++)
                    {
                        if (format == imageFormats[i])
                        {
                            ImageFormat(path);
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


        private void ImageFormat(string path)
        {
            elementPanel.BackgroundImage = new Bitmap(path);
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
    }
}
