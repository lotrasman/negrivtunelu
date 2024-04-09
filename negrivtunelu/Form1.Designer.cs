namespace negrivtunelu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlatno = new System.Windows.Forms.PictureBox();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.tsMysSouradnice = new System.Windows.Forms.ToolStripStatusLabel();
            this.btSmazatPlatno = new System.Windows.Forms.Button();
            this.gbBarvy = new System.Windows.Forms.GroupBox();
            this.pnFillBarva = new System.Windows.Forms.Panel();
            this.pnAktBarva = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnBlue = new System.Windows.Forms.Panel();
            this.pnRed = new System.Windows.Forms.Panel();
            this.pnWhite = new System.Windows.Forms.Panel();
            this.pnBlack = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Line = new System.Windows.Forms.RadioButton();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.rbBox = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Soubor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUlozit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOtevrit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPB = new System.Windows.Forms.Panel();
            this.panelNastroje = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.ssBottom.SuspendLayout();
            this.gbBarvy.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnPB.SuspendLayout();
            this.panelNastroje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbPlatno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlatno.Location = new System.Drawing.Point(0, 0);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(1417, 629);
            this.pbPlatno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlatno.TabIndex = 0;
            this.pbPlatno.TabStop = false;
            this.pbPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseDown);
            this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
            this.pbPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseUp);
            // 
            // ssBottom
            // 
            this.ssBottom.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMysSouradnice});
            this.ssBottom.Location = new System.Drawing.Point(0, 743);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(1418, 22);
            this.ssBottom.TabIndex = 2;
            this.ssBottom.Text = "statusStrip1";
            // 
            // tsMysSouradnice
            // 
            this.tsMysSouradnice.Name = "tsMysSouradnice";
            this.tsMysSouradnice.Size = new System.Drawing.Size(46, 17);
            this.tsMysSouradnice.Text = "x: 0 y: 0";
            // 
            // btSmazatPlatno
            // 
            this.btSmazatPlatno.Location = new System.Drawing.Point(435, 9);
            this.btSmazatPlatno.Margin = new System.Windows.Forms.Padding(2);
            this.btSmazatPlatno.Name = "btSmazatPlatno";
            this.btSmazatPlatno.Size = new System.Drawing.Size(27, 29);
            this.btSmazatPlatno.TabIndex = 3;
            this.btSmazatPlatno.Text = "C";
            this.btSmazatPlatno.UseVisualStyleBackColor = true;
            this.btSmazatPlatno.Click += new System.EventHandler(this.btSmazatPlatno_Click);
            // 
            // gbBarvy
            // 
            this.gbBarvy.Controls.Add(this.pnFillBarva);
            this.gbBarvy.Controls.Add(this.pnAktBarva);
            this.gbBarvy.Controls.Add(this.panel6);
            this.gbBarvy.Controls.Add(this.panel5);
            this.gbBarvy.Controls.Add(this.btSmazatPlatno);
            this.gbBarvy.Controls.Add(this.panel4);
            this.gbBarvy.Controls.Add(this.panel3);
            this.gbBarvy.Controls.Add(this.panel2);
            this.gbBarvy.Controls.Add(this.panel1);
            this.gbBarvy.Controls.Add(this.pnBlue);
            this.gbBarvy.Controls.Add(this.pnRed);
            this.gbBarvy.Controls.Add(this.pnWhite);
            this.gbBarvy.Controls.Add(this.pnBlack);
            this.gbBarvy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBarvy.Location = new System.Drawing.Point(5, 2);
            this.gbBarvy.Margin = new System.Windows.Forms.Padding(2);
            this.gbBarvy.Name = "gbBarvy";
            this.gbBarvy.Padding = new System.Windows.Forms.Padding(2);
            this.gbBarvy.Size = new System.Drawing.Size(661, 82);
            this.gbBarvy.TabIndex = 4;
            this.gbBarvy.TabStop = false;
            this.gbBarvy.Text = "Barvy";
            // 
            // pnFillBarva
            // 
            this.pnFillBarva.BackColor = System.Drawing.Color.White;
            this.pnFillBarva.Location = new System.Drawing.Point(198, 36);
            this.pnFillBarva.Margin = new System.Windows.Forms.Padding(2);
            this.pnFillBarva.Name = "pnFillBarva";
            this.pnFillBarva.Size = new System.Drawing.Size(38, 27);
            this.pnFillBarva.TabIndex = 7;
            // 
            // pnAktBarva
            // 
            this.pnAktBarva.BackColor = System.Drawing.Color.Black;
            this.pnAktBarva.Location = new System.Drawing.Point(198, 8);
            this.pnAktBarva.Margin = new System.Windows.Forms.Padding(2);
            this.pnAktBarva.Name = "pnAktBarva";
            this.pnAktBarva.Size = new System.Drawing.Size(38, 27);
            this.pnAktBarva.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(144, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 19);
            this.panel6.TabIndex = 3;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel5.Location = new System.Drawing.Point(144, 9);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 19);
            this.panel5.TabIndex = 3;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Location = new System.Drawing.Point(120, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 19);
            this.panel4.TabIndex = 3;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(120, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 19);
            this.panel3.TabIndex = 3;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Location = new System.Drawing.Point(96, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 19);
            this.panel2.TabIndex = 5;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(96, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 19);
            this.panel1.TabIndex = 4;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // pnBlue
            // 
            this.pnBlue.BackColor = System.Drawing.Color.Blue;
            this.pnBlue.Location = new System.Drawing.Point(72, 32);
            this.pnBlue.Margin = new System.Windows.Forms.Padding(2);
            this.pnBlue.Name = "pnBlue";
            this.pnBlue.Size = new System.Drawing.Size(20, 19);
            this.pnBlue.TabIndex = 3;
            this.pnBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // pnRed
            // 
            this.pnRed.BackColor = System.Drawing.Color.Red;
            this.pnRed.Location = new System.Drawing.Point(72, 9);
            this.pnRed.Margin = new System.Windows.Forms.Padding(2);
            this.pnRed.Name = "pnRed";
            this.pnRed.Size = new System.Drawing.Size(20, 19);
            this.pnRed.TabIndex = 2;
            this.pnRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // pnWhite
            // 
            this.pnWhite.BackColor = System.Drawing.Color.White;
            this.pnWhite.Location = new System.Drawing.Point(54, 32);
            this.pnWhite.Margin = new System.Windows.Forms.Padding(2);
            this.pnWhite.Name = "pnWhite";
            this.pnWhite.Size = new System.Drawing.Size(20, 19);
            this.pnWhite.TabIndex = 1;
            this.pnWhite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // pnBlack
            // 
            this.pnBlack.BackColor = System.Drawing.Color.Black;
            this.pnBlack.Location = new System.Drawing.Point(54, 9);
            this.pnBlack.Margin = new System.Windows.Forms.Padding(2);
            this.pnBlack.Name = "pnBlack";
            this.pnBlack.Size = new System.Drawing.Size(20, 19);
            this.pnBlack.TabIndex = 0;
            this.pnBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColorClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Controls.Add(this.rbElipse);
            this.groupBox1.Controls.Add(this.rbBox);
            this.groupBox1.Controls.Add(this.rbPen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(671, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nástroj";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(66, 19);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(49, 17);
            this.Line.TabIndex = 10;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanges);
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.Location = new System.Drawing.Point(0, 55);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(59, 17);
            this.rbElipse.TabIndex = 2;
            this.rbElipse.Text = "Elipse";
            this.rbElipse.UseVisualStyleBackColor = true;
            this.rbElipse.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanges);
            // 
            // rbBox
            // 
            this.rbBox.AutoSize = true;
            this.rbBox.Location = new System.Drawing.Point(0, 35);
            this.rbBox.Name = "rbBox";
            this.rbBox.Size = new System.Drawing.Size(46, 17);
            this.rbBox.TabIndex = 1;
            this.rbBox.Text = "Box";
            this.rbBox.UseVisualStyleBackColor = true;
            this.rbBox.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanges);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(0, 19);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(47, 17);
            this.rbPen.TabIndex = 0;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanges);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Soubor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1418, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Soubor
            // 
            this.Soubor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUlozit,
            this.tsmiOtevrit,
            this.tsmiKonec});
            this.Soubor.Name = "Soubor";
            this.Soubor.Size = new System.Drawing.Size(57, 22);
            this.Soubor.Text = "Soubor";
            // 
            // tsmiUlozit
            // 
            this.tsmiUlozit.Name = "tsmiUlozit";
            this.tsmiUlozit.Size = new System.Drawing.Size(180, 22);
            this.tsmiUlozit.Text = "Uložit";
            this.tsmiUlozit.Click += new System.EventHandler(this.tsmiUlozit_Click);
            // 
            // tsmiOtevrit
            // 
            this.tsmiOtevrit.Name = "tsmiOtevrit";
            this.tsmiOtevrit.Size = new System.Drawing.Size(180, 22);
            this.tsmiOtevrit.Text = "Otevřít";
            this.tsmiOtevrit.Click += new System.EventHandler(this.tsmiOtevrit_Click);
            // 
            // tsmiKonec
            // 
            this.tsmiKonec.Name = "tsmiKonec";
            this.tsmiKonec.Size = new System.Drawing.Size(180, 22);
            this.tsmiKonec.Text = "Konec";
            this.tsmiKonec.Click += new System.EventHandler(this.tsmiKonec_Click);
            // 
            // pnPB
            // 
            this.pnPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPB.AutoSize = true;
            this.pnPB.Controls.Add(this.pbPlatno);
            this.pnPB.Location = new System.Drawing.Point(0, 114);
            this.pnPB.Name = "pnPB";
            this.pnPB.Size = new System.Drawing.Size(1417, 629);
            this.pnPB.TabIndex = 8;
            // 
            // panelNastroje
            // 
            this.panelNastroje.Controls.Add(this.groupBox1);
            this.panelNastroje.Controls.Add(this.gbBarvy);
            this.panelNastroje.Location = new System.Drawing.Point(0, 27);
            this.panelNastroje.Name = "panelNastroje";
            this.panelNastroje.Size = new System.Drawing.Size(822, 90);
            this.panelNastroje.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 765);
            this.Controls.Add(this.panelNastroje);
            this.Controls.Add(this.pnPB);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kreslení";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.gbBarvy.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnPB.ResumeLayout(false);
            this.panelNastroje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsMysSouradnice;
        private System.Windows.Forms.Button btSmazatPlatno;
        private System.Windows.Forms.GroupBox gbBarvy;
        private System.Windows.Forms.Panel pnBlack;
        private System.Windows.Forms.Panel pnBlue;
        private System.Windows.Forms.Panel pnRed;
        private System.Windows.Forms.Panel pnWhite;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Soubor;
        private System.Windows.Forms.ToolStripMenuItem tsmiUlozit;
        private System.Windows.Forms.ToolStripMenuItem tsmiOtevrit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKonec;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.Panel pnFillBarva;
        private System.Windows.Forms.Panel pnAktBarva;
        private System.Windows.Forms.Panel pnPB;
        private System.Windows.Forms.Panel panelNastroje;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton Line;
    }
}

