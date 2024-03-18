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
            this.pnBlack = new System.Windows.Forms.Panel();
            this.pnWhite = new System.Windows.Forms.Panel();
            this.pnRed = new System.Windows.Forms.Panel();
            this.pnBlue = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.ssBottom.SuspendLayout();
            this.gbBarvy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Location = new System.Drawing.Point(142, 164);
            this.pbPlatno.Margin = new System.Windows.Forms.Padding(6);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(1152, 598);
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
            this.ssBottom.Location = new System.Drawing.Point(0, 823);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.ssBottom.Size = new System.Drawing.Size(1600, 42);
            this.ssBottom.TabIndex = 2;
            this.ssBottom.Text = "statusStrip1";
            // 
            // tsMysSouradnice
            // 
            this.tsMysSouradnice.Name = "tsMysSouradnice";
            this.tsMysSouradnice.Size = new System.Drawing.Size(94, 32);
            this.tsMysSouradnice.Text = "x: 0 y: 0";
            // 
            // btSmazatPlatno
            // 
            this.btSmazatPlatno.Location = new System.Drawing.Point(0, -5);
            this.btSmazatPlatno.Name = "btSmazatPlatno";
            this.btSmazatPlatno.Size = new System.Drawing.Size(54, 55);
            this.btSmazatPlatno.TabIndex = 3;
            this.btSmazatPlatno.Text = "C";
            this.btSmazatPlatno.UseVisualStyleBackColor = true;
            this.btSmazatPlatno.Click += new System.EventHandler(this.btSmazatPlatno_Click);
            // 
            // gbBarvy
            // 
            this.gbBarvy.Controls.Add(this.pnBlue);
            this.gbBarvy.Controls.Add(this.pnRed);
            this.gbBarvy.Controls.Add(this.pnWhite);
            this.gbBarvy.Controls.Add(this.pnBlack);
            this.gbBarvy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBarvy.Location = new System.Drawing.Point(142, 12);
            this.gbBarvy.Name = "gbBarvy";
            this.gbBarvy.Size = new System.Drawing.Size(1152, 128);
            this.gbBarvy.TabIndex = 4;
            this.gbBarvy.TabStop = false;
            this.gbBarvy.Text = "Barvy";
            // 
            // pnBlack
            // 
            this.pnBlack.BackColor = System.Drawing.Color.Black;
            this.pnBlack.Location = new System.Drawing.Point(108, 18);
            this.pnBlack.Name = "pnBlack";
            this.pnBlack.Size = new System.Drawing.Size(41, 37);
            this.pnBlack.TabIndex = 0;
            this.pnBlack.Click += new System.EventHandler(this.pnColorClick);
            // 
            // pnWhite
            // 
            this.pnWhite.BackColor = System.Drawing.Color.White;
            this.pnWhite.Location = new System.Drawing.Point(108, 61);
            this.pnWhite.Name = "pnWhite";
            this.pnWhite.Size = new System.Drawing.Size(41, 37);
            this.pnWhite.TabIndex = 1;
            this.pnWhite.Click += new System.EventHandler(this.pnColorClick);
            // 
            // pnRed
            // 
            this.pnRed.BackColor = System.Drawing.Color.Red;
            this.pnRed.Location = new System.Drawing.Point(145, 18);
            this.pnRed.Name = "pnRed";
            this.pnRed.Size = new System.Drawing.Size(41, 37);
            this.pnRed.TabIndex = 2;
            this.pnRed.Click += new System.EventHandler(this.pnColorClick);
            // 
            // pnBlue
            // 
            this.pnBlue.BackColor = System.Drawing.Color.Blue;
            this.pnBlue.Location = new System.Drawing.Point(145, 61);
            this.pnBlue.Name = "pnBlue";
            this.pnBlue.Size = new System.Drawing.Size(41, 37);
            this.pnBlue.TabIndex = 3;
            this.pnBlue.Click += new System.EventHandler(this.pnColorClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.gbBarvy);
            this.Controls.Add(this.btSmazatPlatno);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.pbPlatno);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Kreslení";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.gbBarvy.ResumeLayout(false);
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
    }
}

