namespace PostcardGenerator
{
    partial class TextSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choosingColor = new System.Windows.Forms.ColorDialog();
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.radioBold = new System.Windows.Forms.RadioButton();
            this.radioUnderline = new System.Windows.Forms.RadioButton();
            this.radioStrikeout = new System.Windows.Forms.RadioButton();
            this.fontsComboBox = new System.Windows.Forms.ComboBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.colorEditor = new System.Windows.Forms.Button();
            this.fontLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioRegular
            // 
            this.radioRegular.AutoSize = true;
            this.radioRegular.Location = new System.Drawing.Point(26, 240);
            this.radioRegular.Name = "radioRegular";
            this.radioRegular.Size = new System.Drawing.Size(62, 17);
            this.radioRegular.TabIndex = 0;
            this.radioRegular.TabStop = true;
            this.radioRegular.Text = "Regular";
            this.radioRegular.UseVisualStyleBackColor = true;
            this.radioRegular.CheckedChanged += new System.EventHandler(this.radioRegular_CheckedChanged);
            // 
            // radioBold
            // 
            this.radioBold.AutoSize = true;
            this.radioBold.Location = new System.Drawing.Point(26, 263);
            this.radioBold.Name = "radioBold";
            this.radioBold.Size = new System.Drawing.Size(46, 17);
            this.radioBold.TabIndex = 1;
            this.radioBold.TabStop = true;
            this.radioBold.Text = "Bold";
            this.radioBold.UseVisualStyleBackColor = true;
            this.radioBold.CheckedChanged += new System.EventHandler(this.radioBold_CheckedChanged);
            // 
            // radioUnderline
            // 
            this.radioUnderline.AutoSize = true;
            this.radioUnderline.Location = new System.Drawing.Point(237, 239);
            this.radioUnderline.Name = "radioUnderline";
            this.radioUnderline.Size = new System.Drawing.Size(70, 17);
            this.radioUnderline.TabIndex = 2;
            this.radioUnderline.TabStop = true;
            this.radioUnderline.Text = "Underline";
            this.radioUnderline.UseVisualStyleBackColor = true;
            this.radioUnderline.CheckedChanged += new System.EventHandler(this.radioUnderline_CheckedChanged);
            // 
            // radioStrikeout
            // 
            this.radioStrikeout.AutoSize = true;
            this.radioStrikeout.Location = new System.Drawing.Point(237, 263);
            this.radioStrikeout.Name = "radioStrikeout";
            this.radioStrikeout.Size = new System.Drawing.Size(67, 17);
            this.radioStrikeout.TabIndex = 3;
            this.radioStrikeout.TabStop = true;
            this.radioStrikeout.Text = "Strikeout";
            this.radioStrikeout.UseVisualStyleBackColor = true;
            this.radioStrikeout.CheckedChanged += new System.EventHandler(this.radioStrikeout_CheckedChanged);
            // 
            // fontsComboBox
            // 
            this.fontsComboBox.FormattingEnabled = true;
            this.fontsComboBox.Location = new System.Drawing.Point(12, 26);
            this.fontsComboBox.Name = "fontsComboBox";
            this.fontsComboBox.Size = new System.Drawing.Size(121, 21);
            this.fontsComboBox.TabIndex = 4;
            this.fontsComboBox.SelectedIndexChanged += new System.EventHandler(this.fontsComboBox_SelectedIndexChanged);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62",
            "64",
            "66",
            "68",
            "70",
            "72"});
            this.sizeComboBox.Location = new System.Drawing.Point(267, 26);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeComboBox.TabIndex = 5;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // colorEditor
            // 
            this.colorEditor.Location = new System.Drawing.Point(102, 76);
            this.colorEditor.Name = "colorEditor";
            this.colorEditor.Size = new System.Drawing.Size(189, 71);
            this.colorEditor.TabIndex = 6;
            this.colorEditor.Text = "CHOOSE YOUR COLOUR";
            this.colorEditor.UseVisualStyleBackColor = true;
            this.colorEditor.Click += new System.EventHandler(this.colorEditor_Click);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(12, 10);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(28, 13);
            this.fontLabel.TabIndex = 7;
            this.fontLabel.Text = "Font";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(264, 9);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "Size";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(12, 175);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(71, 13);
            this.testLabel.TabIndex = 9;
            this.testLabel.Text = "TEST LABEL";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(134, 305);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(117, 42);
            this.applyButton.TabIndex = 10;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // TextSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 359);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.radioStrikeout);
            this.Controls.Add(this.radioUnderline);
            this.Controls.Add(this.radioBold);
            this.Controls.Add(this.radioRegular);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.colorEditor);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.fontsComboBox);
            this.MaximumSize = new System.Drawing.Size(416, 398);
            this.MinimumSize = new System.Drawing.Size(416, 398);
            this.Name = "TextSetting";
            this.Text = "TextSetting";
            this.Load += new System.EventHandler(this.TextSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog choosingColor;
        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.RadioButton radioBold;
        private System.Windows.Forms.RadioButton radioUnderline;
        private System.Windows.Forms.RadioButton radioStrikeout;
        private System.Windows.Forms.ComboBox fontsComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Button colorEditor;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button applyButton;
    }
}