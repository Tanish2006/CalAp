using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalAp
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        int i=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            
            if (i >= 10)
            {
                timer1.Stop();
                Form2 l1 = new Form2();
                l1.Show();

                this.Hide();

            }
            else
            {
                int initailWidth = 52; 
                if(panel1.Size.Width <= 193)
                {
                    panel1.Size = new Size(initailWidth + i * 16, 3);
                }
                
            }
        }
    }
}
