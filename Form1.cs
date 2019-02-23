using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakala
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        Random rnd = new Random();
        private void btnTikla_MouseEnter(object sender, EventArgs e)
        {

            
            btnTikla.Left = rnd.Next(0, (this.ClientSize.Width - btnTikla.Size.Width));
            btnTikla.Top  = rnd.Next(0, (this.ClientSize.Height - btnTikla.Size.Height));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
            sayac++;
            Text = sayac.ToString();

        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
           
            btnTikla.Left = 409;
            btnTikla.Top= 247;
            //MessageBox.Show(string.Format("Tebrikler, {0}. denemede kazandınız", sayac));
            MessageBox.Show($"Tebrikler, {sayac}. denemede kazandınız");
            sayac=0;
            Text = sayac.ToString();
        }
    }
}
