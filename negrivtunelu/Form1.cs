using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        
        public Form1()
        {
            InitializeComponent();
           //umoznuje mazani pomoci c
            this.KeyPreview = true;
            
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
                if(Kresli== true ) 
                {   
                    if (predchoziBod != null) 
                    {
                        mobjGrafika.DrawLine(Pens.Black, (Point)predchoziBod, new Point(e.X, e.Y));
                    }
                   // ulozi aktualni coords do predchoziBod
                    predchoziBod = new Point(e.X, e.Y);
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
        predchoziBod = new Point(e.X, e.Y);
        }
        //
        //zvednuti tlacitka mysi pri kresleni
        //
        private void pbPlatno_MouseUp(object sender, MouseEventArgs e)
        {
            Kresli= false;
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
        
    }

}
