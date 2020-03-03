using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clicar n = new clicar();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = n.timeS();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = n.points();
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

       

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            n.treset();
            n.preset();
            timer1.Stop();
        }
    }
}
