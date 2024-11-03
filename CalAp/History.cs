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
    public partial class History : Form
    {
        string[] History1 = new string[10];
        int cnt = 0;
        public History(string[] History1,int cnt)
        {
            InitializeComponent();
            
            this.cnt = cnt;
            this.History1 = History1;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
 

            label1.Text = "";
            int no = 1;
            while (no <= cnt)
            {
                label1.Text += History1[no] + "\n\n";
                no = no + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
