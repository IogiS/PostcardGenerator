using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostcardGenerator.Work
{
    class TextEvents : IEvents
    {


        ComboBox fontsComboBox { get; set; }
        ComboBox sizeComboBox { get; set; }

        ColorDialog choosingColor { get; set; }

        public Label testLabel { get; set; }

        public TextEvents(ComboBox fontsComboBox, ComboBox sizeComboBox, Label testLabel, ColorDialog choosingColor)
        {
            this.fontsComboBox = fontsComboBox;
            this.sizeComboBox = sizeComboBox;
            this.testLabel = testLabel;
            this.choosingColor = choosingColor;
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

        public void saveSettings(Font font, Size size, Color color)
        {
            TextSettings.font = font;
            TextSettings.color = color;
            TextSettings.changed = true;

        }
    }
}
