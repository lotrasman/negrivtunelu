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
        public Form1()
        {
            InitializeComponent();
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
        //testovaci tlacitko
        private void button1_Click(object sender, EventArgs e)
        {
            mobjGrafika.DrawLine(Pens.Red, 10, 10, 100, 100);
            mobjGrafika.FillEllipse(Brushes.RoyalBlue, 80,80,200,400);
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
            tsMysSouradnice.Text="x:" + e.X.ToString() + "y:" + e.Y.ToString();
            }
            catch(Exception ex) 
            {
            
            }
        }
    }
}
