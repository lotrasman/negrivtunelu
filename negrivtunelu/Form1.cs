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
        Point? predchoziBod = null;
        bool Kresli = false;
        bool OpravduKresli = false;
        Color mobjAktBarva;
        enum enTools { Pero , Box }
        enTools mobjAktTool;
        
        
        public Form1()
        {
            InitializeComponent();
           //umoznuje mazani pomoci c
            this.KeyPreview = true;
            mobjAktBarva = Color.Black;
            mobjAktTool = enTools.Pero;
            
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
                tsMysSouradnice.Text ="x:" + e.X.ToString() + "y:" + e.Y.ToString();
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
                                    mobjGrafika.DrawLine(new Pen(mobjAktBarva), (Point)predchoziBod, new Point(e.X, e.Y));
                                }
                                // ulozi aktualni coords do predchoziBod
                                predchoziBod = new Point(e.X, e.Y);
                            }
                            
                
                
                        }
                        break;
                    case enTools.Box://doplnit
                        if (mobjAktTool == enTools.Box) 
                        {
                            mobjGrafika.DrawRectangle(new Pen(mobjAktBarva), (Point)predchoziBod);
                        }

                        
                        break;


                }
            }
            catch(Exception ex) 
            {
            
            }
        }
        //
        //stisknuti tlacitka mysi pro kresleni
        //
        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
        Kresli = true;
        //predchoziBod = new Point(e.X, e.Y);
        }
        //
        //zvednuti tlacitka mysi pri kresleni
        //
        private void pbPlatno_MouseUp(object sender, MouseEventArgs e)
        {
            Kresli= false;
            predchoziBod = null;
        }
        //
        //rutina pro vymazani platna
        //
        private void btSmazatPlatno_Click(object sender, EventArgs e)
        {
            mobjGrafika.Clear(Color.White);
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
           
            mobjGrafika = pbPlatno.CreateGraphics();
            
        }

        private void pnColorClick(object sender, EventArgs e)
        {
            Panel lobjPanel;
            
            lobjPanel = (Panel)sender;

            if (lobjPanel != null) 
            {
                mobjAktBarva = lobjPanel.BackColor;
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

                }
            }
            catch(Exception ex) 
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
                pbPlatno.Image.Save("c:\\Temp\\obrazek.jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex) { }
        }
    }

}
