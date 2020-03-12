using PostcardGenerator.Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostcardGenerator
{

    
    public partial class TextSetting : Form
    {

        

        Events events;

        public TextSetting()
        {
            InitializeComponent();
            events = new Events(fontsComboBox,sizeComboBox,testLabel, choosingColor);
        }

        private void TextSetting_Load(object sender, EventArgs e)
        {
            TextSettings.LoadFonts(fontsComboBox);
            fontsComboBox.Text = fontsComboBox.Items[0].ToString();
            sizeComboBox.Text = sizeComboBox.Items[0].ToString();
        }

        private void fontsComboBox_SelectedIndexChanged(object sender, EventArgs e) => events.fontsChange();


        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e) => events.sizeChange();

        private void applyButton_Click(object sender, EventArgs e) => events.saveSettings(testLabel.Font, testLabel.Size, testLabel.ForeColor);


        private void colorEditor_Click(object sender, EventArgs e) => events.colorChange();


        private void radioRegular_CheckedChanged(object sender, EventArgs e) => events.changeToRegular();

        private void radioBold_CheckedChanged(object sender, EventArgs e) => events.changeToBold();

        private void radioUnderline_CheckedChanged(object sender, EventArgs e) => events.changeToUnderLine();


        private void radioStrikeout_CheckedChanged(object sender, EventArgs e) => events.changeToStrikeout();

    }
}
