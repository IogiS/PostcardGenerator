namespace PostcardGenerator
{
    partial class Generator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.postcardPanel = new System.Windows.Forms.Panel();
            this.componentsPanel = new System.Windows.Forms.Panel();
            this.postcardTemplatePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.openProjektButton = new System.Windows.Forms.Button();
            this.postcardLabel = new System.Windows.Forms.Label();
            this.postcardElementsLabel = new System.Windows.Forms.Label();
            this.templatePostcardLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.postcardPanel.SuspendLayout();
            this.postcardTemplatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // postcardPanel
            // 
            this.postcardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postcardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postcardPanel.Controls.Add(this.panel6);
            this.postcardPanel.Location = new System.Drawing.Point(12, 97);
            this.postcardPanel.Name = "postcardPanel";
            this.postcardPanel.Size = new System.Drawing.Size(791, 457);
            this.postcardPanel.TabIndex = 0;
            // 
            // componentsPanel
            // 
            this.componentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentsPanel.Location = new System.Drawing.Point(809, 97);
            this.componentsPanel.Name = "componentsPanel";
            this.componentsPanel.Size = new System.Drawing.Size(250, 457);
            this.componentsPanel.TabIndex = 1;
            // 
            // postcardTemplatePanel
            // 
            this.postcardTemplatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postcardTemplatePanel.Controls.Add(this.panel5);
            this.postcardTemplatePanel.Controls.Add(this.panel4);
            this.postcardTemplatePanel.Controls.Add(this.panel3);
            this.postcardTemplatePanel.Controls.Add(this.panel2);
            this.postcardTemplatePanel.Controls.Add(this.panel1);
            this.postcardTemplatePanel.Location = new System.Drawing.Point(12, 588);
            this.postcardTemplatePanel.Name = "postcardTemplatePanel";
            this.postcardTemplatePanel.Size = new System.Drawing.Size(1047, 121);
            this.postcardTemplatePanel.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(836, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 1;
            this.panel5.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(630, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            this.panel4.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(424, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            this.panel3.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(218, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            this.panel2.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(301, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(164, 43);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // openProjektButton
            // 
            this.openProjektButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openProjektButton.Location = new System.Drawing.Point(483, 12);
            this.openProjektButton.Name = "openProjektButton";
            this.openProjektButton.Size = new System.Drawing.Size(170, 43);
            this.openProjektButton.TabIndex = 4;
            this.openProjektButton.Text = "Открыть проект";
            this.openProjektButton.UseVisualStyleBackColor = true;
            // 
            // postcardLabel
            // 
            this.postcardLabel.AutoSize = true;
            this.postcardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postcardLabel.Location = new System.Drawing.Point(8, 58);
            this.postcardLabel.Name = "postcardLabel";
            this.postcardLabel.Size = new System.Drawing.Size(97, 24);
            this.postcardLabel.TabIndex = 0;
            this.postcardLabel.Text = "Открытка";
            // 
            // postcardElementsLabel
            // 
            this.postcardElementsLabel.AutoSize = true;
            this.postcardElementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postcardElementsLabel.Location = new System.Drawing.Point(805, 58);
            this.postcardElementsLabel.Name = "postcardElementsLabel";
            this.postcardElementsLabel.Size = new System.Drawing.Size(102, 24);
            this.postcardElementsLabel.TabIndex = 5;
            this.postcardElementsLabel.Text = "Элементы";
            // 
            // templatePostcardLabel
            // 
            this.templatePostcardLabel.AutoSize = true;
            this.templatePostcardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.templatePostcardLabel.Location = new System.Drawing.Point(8, 559);
            this.templatePostcardLabel.Name = "templatePostcardLabel";
            this.templatePostcardLabel.Size = new System.Drawing.Size(179, 24);
            this.templatePostcardLabel.TabIndex = 6;
            this.templatePostcardLabel.Text = "Шаблоны открыток";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(288, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 79);
            this.panel6.TabIndex = 0;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 725);
            this.Controls.Add(this.templatePostcardLabel);
            this.Controls.Add(this.postcardElementsLabel);
            this.Controls.Add(this.postcardLabel);
            this.Controls.Add(this.openProjektButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.postcardTemplatePanel);
            this.Controls.Add(this.componentsPanel);
            this.Controls.Add(this.postcardPanel);
            this.Name = "Generator";
            this.Text = "PostcardsGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.postcardPanel.ResumeLayout(false);
            this.postcardTemplatePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel postcardPanel;
        private System.Windows.Forms.Panel componentsPanel;
        private System.Windows.Forms.Panel postcardTemplatePanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openProjektButton;
        private System.Windows.Forms.Label postcardLabel;
        private System.Windows.Forms.Label postcardElementsLabel;
        private System.Windows.Forms.Label templatePostcardLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
    }
}

