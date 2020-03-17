using PostcardGenerator.Work;
using System;
using System.Windows.Forms;

namespace PostcardGenerator
{

    
    public partial class TextSetting : Form
    {

        

        TextEvents events;

        public TextSetting()
        {
            InitializeComponent();
            events = new TextEvents(fontsComboBox,sizeComboBox,testLabel, choosingColor);
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

        private void TextSetting_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
