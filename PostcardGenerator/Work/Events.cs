using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace PostcardGenerator.Work
{
    public class Events : IEvents
    {

        Panel elementPanel { get; set; }
         Panel musicPanel { get; set; }
         Label elementLabel { get; set; }
         Label elementsMusicLabel { get; set; }
         TrackBar volumeScroll { get; set; }

        TextBox textBox { get; set; }
        
         ComboBox fontsComboBox { get; set; }
         ComboBox sizeComboBox { get; set; }

        ColorDialog choosingColor { get; set; }
        public Label testLabel { get; set; }
        public Events(Panel elementPanel, Label elementLabel, Panel musicPanel, Label elementsMusicLabel, TrackBar volumeScroll, TextBox textBox)
        {
            this.elementPanel = elementPanel;
            this.musicPanel = musicPanel;
            this.elementLabel = elementLabel;
            this.elementsMusicLabel = elementsMusicLabel;
            this.volumeScroll = volumeScroll;
            this.textBox = textBox;
        }
        public Events(ComboBox fontsComboBox, ComboBox sizeComboBox, Label testLabel, ColorDialog choosingColor) 
        {
            this.fontsComboBox = fontsComboBox;
            this.sizeComboBox = sizeComboBox;
            this.testLabel = testLabel;
            this.choosingColor = choosingColor;
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

        public void showTextSettings()
        {
            TextSetting textSetting = new TextSetting();
            textSetting.Show();
        }

        public void fontsChange()
        {
            try
            {
                testLabel.Font = new Font(fontsComboBox.Text, testLabel.Font.Size);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void sizeChange()
        {
            try
            {
                testLabel.Font = new Font(testLabel.Font.FontFamily, float.Parse(sizeComboBox.SelectedItem.ToString()));

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void colorChange()
        {
            try
            {
                DialogResult colors = choosingColor.ShowDialog();
                if (colors == DialogResult.OK)
                {
                    testLabel.ForeColor = choosingColor.Color;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void changeToRegular() => testLabel.Font = new Font(testLabel.Font.FontFamily, testLabel.Font.Size, FontStyle.Regular);

        public void changeToBold() => testLabel.Font = new Font(testLabel.Font.FontFamily, testLabel.Font.Size, FontStyle.Bold);

        public void changeToUnderLine() => testLabel.Font = new Font(testLabel.Font.FontFamily, testLabel.Font.Size, FontStyle.Underline);

        public void changeToStrikeout() => testLabel.Font = new Font(testLabel.Font.FontFamily, testLabel.Font.Size, FontStyle.Strikeout);

        public void saveSettings(Font font, Size size,Color color)
        {
            TextSettings.font = font;
            TextSettings.color = color;
            TextSettings.changed = true;
            
        }
    }
}
