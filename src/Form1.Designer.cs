namespace AntoineEquation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Temperature";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "c=";
            // 
            // temperatureInitial
            // 
            this.temperatureInitial.Location = new System.Drawing.Point(125, 21);
            this.temperatureInitial.Name = "temperatureInitial";
            this.temperatureInitial.Size = new System.Drawing.Size(100, 20);
            this.temperatureInitial.TabIndex = 1;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(44, 37);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(100, 20);
            this.aBox.TabIndex = 7;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(44, 65);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 20);
            this.bBox.TabIndex = 8;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(44, 90);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(100, 20);
            this.cBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generate Plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Initial Pressure=";
            // 
            // pBox
            // 
            this.pBox.AutoSize = true;
            this.pBox.Location = new System.Drawing.Point(185, 220);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(0, 13);
            this.pBox.TabIndex = 10;
            // 
            // temperatureFinal
            // 
            this.temperatureFinal.Location = new System.Drawing.Point(125, 47);
            this.temperatureFinal.Name = "temperatureFinal";
            this.temperatureFinal.Size = new System.Drawing.Size(100, 20);
            this.temperatureFinal.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
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
            this.label6.Location = new System.Drawing.Point(6, 50);
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
            this.unitsTemp.Location = new System.Drawing.Point(276, 47);
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
            this.unitsAntoine.Location = new System.Drawing.Point(267, 87);
            this.unitsAntoine.Name = "unitsAntoine";
            this.unitsAntoine.Size = new System.Drawing.Size(81, 21);
            this.unitsAntoine.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Final Pressure=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Units:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 97);
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
            this.unitsPressure.Location = new System.Drawing.Point(276, 97);
            this.unitsPressure.Name = "unitsPressure";
            this.unitsPressure.Size = new System.Drawing.Size(81, 21);
            this.unitsPressure.TabIndex = 6;
            // 
            // pBox2
            // 
            this.pBox2.AutoSize = true;
            this.pBox2.Location = new System.Drawing.Point(188, 239);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(0, 13);
            this.pBox2.TabIndex = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aBox);
            this.groupBox1.Controls.Add(this.pBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bBox);
            this.groupBox1.Controls.Add(this.pBox);
            this.groupBox1.Controls.Add(this.cBox);
            this.groupBox1.Controls.Add(this.unitsAntoine);
            this.groupBox1.Location = new System.Drawing.Point(21, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 167);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antoine Constants";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 59);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plot Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.unitsPressure);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.unitsTemp);
            this.groupBox3.Controls.Add(this.temperatureInitial);
            this.groupBox3.Controls.Add(this.temperatureFinal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 144);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot Limits";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 102;
            this.label10.Text = "Units:";
            // 
            // AntoineMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 433);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AntoineMain";
            this.Text = "Antoine\'s Equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

