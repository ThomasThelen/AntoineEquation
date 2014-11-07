namespace WindowsFormsApplication1
{
    partial class AntoineMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temperatureInitial = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.Label();
            this.temperatureFinal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.literatureSourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.unitsTemp = new System.Windows.Forms.ComboBox();
            this.unitsAntoine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.unitsPressure = new System.Windows.Forms.ComboBox();
            this.pBox2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Temperature";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "c=";
            // 
            // temperatureInitial
            // 
            this.temperatureInitial.Location = new System.Drawing.Point(138, 52);
            this.temperatureInitial.Name = "temperatureInitial";
            this.temperatureInitial.Size = new System.Drawing.Size(100, 20);
            this.temperatureInitial.TabIndex = 1;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(135, 109);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(100, 20);
            this.aBox.TabIndex = 4;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(135, 137);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 20);
            this.bBox.TabIndex = 5;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(135, 162);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(100, 20);
            this.cBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get Presure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Initial Pressure=";
            // 
            // pBox
            // 
            this.pBox.AutoSize = true;
            this.pBox.Location = new System.Drawing.Point(238, 242);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(0, 13);
            this.pBox.TabIndex = 10;
            // 
            // temperatureFinal
            // 
            this.temperatureFinal.Location = new System.Drawing.Point(138, 78);
            this.temperatureFinal.Name = "temperatureFinal";
            this.temperatureFinal.Size = new System.Drawing.Size(100, 20);
            this.temperatureFinal.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.findParametersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // findParametersToolStripMenuItem
            // 
            this.findParametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nISTToolStripMenuItem,
            this.literatureSourcesToolStripMenuItem});
            this.findParametersToolStripMenuItem.Name = "findParametersToolStripMenuItem";
            this.findParametersToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.findParametersToolStripMenuItem.Text = "Find Parameters";
            // 
            // nISTToolStripMenuItem
            // 
            this.nISTToolStripMenuItem.Name = "nISTToolStripMenuItem";
            this.nISTToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nISTToolStripMenuItem.Text = "Web Search";
            this.nISTToolStripMenuItem.Click += new System.EventHandler(this.nISTToolStripMenuItem_Click);
            // 
            // literatureSourcesToolStripMenuItem
            // 
            this.literatureSourcesToolStripMenuItem.Name = "literatureSourcesToolStripMenuItem";
            this.literatureSourcesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.literatureSourcesToolStripMenuItem.Text = "Literature Sources";
            this.literatureSourcesToolStripMenuItem.Click += new System.EventHandler(this.literatureSourcesToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Final Temperature";
            // 
            // unitsTemp
            // 
            this.unitsTemp.FormattingEnabled = true;
            this.unitsTemp.Items.AddRange(new object[] {
            "Kelvin",
            "Celcius"});
            this.unitsTemp.Location = new System.Drawing.Point(285, 78);
            this.unitsTemp.Name = "unitsTemp";
            this.unitsTemp.Size = new System.Drawing.Size(81, 21);
            this.unitsTemp.TabIndex = 3;
            // 
            // unitsAntoine
            // 
            this.unitsAntoine.FormattingEnabled = true;
            this.unitsAntoine.Items.AddRange(new object[] {
            "Kelvin",
            "Celcius"});
            this.unitsAntoine.Location = new System.Drawing.Point(285, 162);
            this.unitsAntoine.Name = "unitsAntoine";
            this.unitsAntoine.Size = new System.Drawing.Size(81, 21);
            this.unitsAntoine.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Final Pressure=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Units:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Units:";
            // 
            // unitsPressure
            // 
            this.unitsPressure.FormattingEnabled = true;
            this.unitsPressure.Items.AddRange(new object[] {
            "Bar",
            "Atm",
            "Pa",
            "MPa",
            "mmHg",
            "psi"});
            this.unitsPressure.Location = new System.Drawing.Point(285, 199);
            this.unitsPressure.Name = "unitsPressure";
            this.unitsPressure.Size = new System.Drawing.Size(81, 21);
            this.unitsPressure.TabIndex = 8;
            // 
            // pBox2
            // 
            this.pBox2.AutoSize = true;
            this.pBox2.Location = new System.Drawing.Point(241, 261);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(0, 13);
            this.pBox2.TabIndex = 104;
            // 
            // AntoineMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 304);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.unitsPressure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unitsAntoine);
            this.Controls.Add(this.unitsTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.temperatureFinal);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.temperatureInitial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AntoineMain";
            this.Text = "Antoine\'s Equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temperatureInitial;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pBox;
        private System.Windows.Forms.TextBox temperatureFinal;
        private System.Windows.Forms.DataVisualization.Charting.Chart PTDiagram;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox unitsTemp;
        private System.Windows.Forms.ComboBox unitsAntoine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox unitsPressure;
        private System.Windows.Forms.Label pBox2;
        private System.Windows.Forms.ToolStripMenuItem findParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem literatureSourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

