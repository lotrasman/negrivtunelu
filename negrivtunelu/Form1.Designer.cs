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
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.ssBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Location = new System.Drawing.Point(50, 46);
            this.pbPlatno.Margin = new System.Windows.Forms.Padding(6);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(1073, 522);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsMysSouradnice;
        private System.Windows.Forms.Button btSmazatPlatno;
    }
}

