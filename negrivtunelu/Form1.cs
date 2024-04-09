using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negrivtunelu
{
    public partial class Form1 : Form
    {
        //kreslici objekt grafiky
        Graphics mobjGrafika;
        //kreslici objekt v pameti
        Bitmap mobjBitmap;
        Graphics mobjBMGraphics;
        Point? predchoziBod = null;
        Point? startpoint = null;
        bool Kresli = false;
        bool OpravduKresli = false;
        Color mobjAktBarva;
        Color mobjFillBarva;
        enum enTools { Pero, Box, Elipse, Line }
        enTools mobjAktTool;
        bool isDrawing = false;


        public Form1()
        {
            InitializeComponent();
            //ktery files jsou mozny otevrit a ulozit
            saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png";

            openFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png";

            //umoznuje mazani pomoci c
            this.KeyPreview = true;
            mobjAktBarva = Color.Black;




        }
        /// <summary>
        /// nahrani okna do pameti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //vytvoreni grafiky na pictureboxu
            mobjGrafika = pbPlatno.CreateGraphics();
            //vytvoreni grafiky v ram
            mobjBitmap = new Bitmap(pbPlatno.Width, pbPlatno.Height);
            mobjBMGraphics = Graphics.FromImage(mobjBitmap);
            mobjBMGraphics.Clear(Color.White);
        }
        /// <summary>
        /// pohyb mysi na picture boxem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //souradnice mysi do statusu
                tsMysSouradnice.Text = "x:" + e.X.ToString() + "y:" + e.Y.ToString();
                //kontrola jestli mousedown
                switch (mobjAktTool)
                {
                    case enTools.Pero:
                        if (OpravduKresli == true)
                        {
                            if (Kresli == true)
                            {
                                if (predchoziBod != null)
                                {
                                    mobjBMGraphics.DrawLine(new Pen(mobjAktBarva), (Point)predchoziBod, new Point(e.X, e.Y));
                                }
                                // ulozi aktualni coords do predchoziBod
                                predchoziBod = new Point(e.X, e.Y);
                            }



                        }
                        break;




                }

                pbPlatno.Image = mobjBitmap;
            }
            catch (Exception ex)
            {

            }
        }
        //
        //stisknuti tlacitka mysi pro kresleni
        //
        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
            Kresli = true;
            startpoint = new Point(e.X, e.Y);
            isDrawing = true;
            //predchoziBod = new Point(e.X, e.Y);

        }
        //
        //zvednuti tlacitka mysi pri kresleni (cela kreslici operace pro box a elipse)
        //
        private void pbPlatno_MouseUp(object sender, MouseEventArgs e)
        {
            Kresli = false;
            if (mobjAktTool == enTools.Box && startpoint.HasValue && pnFillBarva.BackColor == Color.White)
            {
                Point value = startpoint.Value;
                int width = Math.Abs(e.X - value.X);
                int height = Math.Abs(e.Y - value.Y);
                int x = Math.Min(e.X, value.X);
                int y = Math.Min(e.Y, value.Y);
                mobjBMGraphics.DrawRectangle(new Pen(mobjAktBarva), x, y, width, height);
                startpoint = null;

            }
            if (mobjAktTool == enTools.Box && startpoint.HasValue && pnFillBarva.BackColor != Color.White)
            {
                Point value = startpoint.Value;
                int width = Math.Abs(e.X - value.X);
                int height = Math.Abs(e.Y - value.Y);
                int x = Math.Min(e.X, value.X);
                int y = Math.Min(e.Y, value.Y);
                mobjBMGraphics.FillRectangle(new SolidBrush(mobjFillBarva), x, y, width, height);
                startpoint = null;
            }
            if (mobjAktTool == enTools.Elipse && startpoint.HasValue && pnFillBarva.BackColor == Color.White)
            {
                Point value = startpoint.Value;
                int width = Math.Abs(e.X - value.X);
                int height = Math.Abs(e.Y - value.Y);
                int x = Math.Min(e.X, value.X);
                int y = Math.Min(e.Y, value.Y);
                mobjBMGraphics.DrawEllipse(new Pen(mobjAktBarva), x, y, width, height);
                startpoint = null;
            }
            if (mobjAktTool == enTools.Elipse && startpoint.HasValue && pnFillBarva.BackColor != Color.White)
            {
                Point value = startpoint.Value;
                int width = Math.Abs(e.X - value.X);
                int height = Math.Abs(e.Y - value.Y);
                int x = Math.Min(e.X, value.X);
                int y = Math.Min(e.Y, value.Y);
                mobjBMGraphics.FillEllipse(new SolidBrush(mobjFillBarva), x, y, width, height);
                startpoint = null;
            }
            if (mobjAktTool == enTools.Line && startpoint.HasValue)
            {
                Point value = startpoint.Value;
                mobjBMGraphics.DrawLine(new Pen(mobjAktBarva), value, new Point(e.X, e.Y));
                startpoint = null;
            }
            pbPlatno.Image = mobjBitmap;
            predchoziBod = null;
        }
        //
        //rutina pro vymazani platna
        //
        private void btSmazatPlatno_Click(object sender, EventArgs e)
        {
            mobjBMGraphics.Clear(Color.White);
            pbPlatno.Image = mobjBitmap;
        }
        // 
        //rutina pro mazani stisknutim c
        //
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                btSmazatPlatno_Click(sender, e);
            }
        }
        // 
        //rutina pro rozsireni kreslici zony pri zvetseni okna
        //
        private void Form1_Resize(object sender, EventArgs e)
        {
            Bitmap newBitmap = new Bitmap(pbPlatno.Width, pbPlatno.Height);
            using (Graphics ResizedGraphics = Graphics.FromImage(newBitmap))
            {
                // Draw the old Bitmap onto the new one using mobjBMGraphics
                ResizedGraphics.DrawImage(mobjBitmap, 0, 0, pbPlatno.Width, pbPlatno.Height);
            }
            // Replace the old Bitmap with the new one
            mobjBitmap = newBitmap;
            // Create a new Graphics object for the new Bitmap
            mobjBMGraphics = Graphics.FromImage(mobjBitmap);

        }

        private void pnColorClick(object sender, MouseEventArgs e)
        {
            Panel lobjPanel;

            lobjPanel = (Panel)sender;

            if (lobjPanel != null && e.Button == MouseButtons.Left)
            {
                mobjAktBarva = lobjPanel.BackColor;
                pnAktBarva.BackColor = lobjPanel.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                mobjFillBarva = lobjPanel.BackColor;
                pnFillBarva.BackColor = lobjPanel.BackColor;
            }
        }

        private void rbTool_CheckedChanges(object sender, EventArgs e)
        {
            try
            {
                RadioButton lobjTool;

                lobjTool = (RadioButton)sender;

                switch (lobjTool.Text)
                {
                    case "Pen":
                        OpravduKresli = true;
                        mobjAktTool = enTools.Pero;
                        break;

                    case "Box":
                        OpravduKresli = false;
                        mobjAktTool = enTools.Box;
                        break;
                    case "Elipse":
                        OpravduKresli = false;
                        mobjAktTool = enTools.Elipse;
                        break;
                    case "Line":
                        OpravduKresli = false;
                        mobjAktTool = enTools.Line;
                        break;

                }
            }
            catch (Exception ex)
            {
                Kresli = true;
                MessageBox.Show("ses mongoloid mongoloide");
            }
        }

        private void tsmiKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilter = saveFileDialog.FilterIndex.ToString();
                    switch (selectedFilter)
                    {
                        case "1": // JPEG
                            mobjBitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                        case "2": // PNG
                            mobjBitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ses mongoloid");
            }
        }

        private void tsmiOtevrit_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    mobjBitmap = new Bitmap(openFileDialog1.FileName);
                    mobjBMGraphics = Graphics.FromImage(mobjBitmap);
                    pbPlatno.Image = mobjBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ses mongoloid");
            }
        }
    }

}