using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalAp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Double result = 0;
        string OperationP = "";
        //VARIABLE

            //FLAG
                bool Checkclear = false;
                bool OperatorC = false;
                bool ResultC = false;
                bool prev = false;
                bool nonNumberEntered = false;
            //END OF FLAG

            //LIST FOR HISTORY
                string[] History = new string[100];
            //END OF LIST

            //COUNTER VARIABLE
                int cntbut=0;
                int cnt = 0;
                int i = 0;
            //VARIABLE
                Double no1  = 0;
                Double no2  = 0;
                Double resultfinal=0;
            //END OFVARIABLE
        //END OF COUNTER VARIABLE


        //END OF VARIABLE

        //USER DEFINED METHODS

        //FUNCTION USED FOR KEY PRESS
                public void btnclick(KeyPressEventArgs e)
            {
                try
                {
                

                        if (richTextBox1.Text == "0")
                        {
                            richTextBox1.Clear();
                        }
                        if (Checkclear == true)
                        {
                            richTextBox1.Clear();
                            lblValue.Text = "";
                            Checkclear = false;
                        }

                        ResultC = false;
                        OperatorC = false;
                        richTextBox1.Text = richTextBox1.Text + e.KeyChar.ToString();
                
                }
                catch (Exception ex)
                {
                    SystemSounds.Asterisk.Play();
                    richTextBox1.Text = ex.ToString();
                }
            }
                public void Prev(KeyPressEventArgs e)
            {
                try
                {
                    if (OperatorC == false)
                    {
                        OperationP = e.KeyChar.ToString();
                        Checkclear = false;
                        result = double.Parse(richTextBox1.Text);

                        lblValue.Text = result + " " + OperationP;
                        richTextBox1.Clear();
                        OperatorC = true;
                        prev = true;

                        ResultC = false;
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();

                    }
                }
                catch(Exception ex)
                {
                    SystemSounds.Asterisk.Play();
                    richTextBox1.Text = ex.ToString();
                }
            }
                public void noPrev(KeyPressEventArgs e)
            {
                switch (OperationP)
                {
                    case "+":
                        if (ResultC == false &&  OperatorC == false)
                        {
                            try
                            {
                            
                                OperationP = e.KeyChar.ToString();
                                lblValue.Text = (result + double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                                result = result + double.Parse(richTextBox1.Text);
                                OperatorC = true;
                                richTextBox1.Clear();
                                ResultC = false;
                            }
                            catch (Exception ex)
                            {
                                SystemSounds.Asterisk.Play();
                                richTextBox1.Text = ex.ToString();
                            }
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                        }
                        break;
                    case "-":
                        if (ResultC == false && OperatorC == false)
                        {
                            try
                            {
                                OperationP = e.KeyChar.ToString();
                                lblValue.Text = (result - double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                                result = result - double.Parse(richTextBox1.Text);
                                OperatorC = true;
                                richTextBox1.Clear();
                                ResultC = false;
                            }
                            catch (Exception ex)
                            {
                                SystemSounds.Asterisk.Play();
                                richTextBox1.Text = ex.ToString();
                            }
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                        }
                        break;
                    case "*":
                        if (ResultC == false && OperatorC == false)
                        {
                            try
                            {
                                OperationP = e.KeyChar.ToString();
                                lblValue.Text = (result * double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                                result = result * double.Parse(richTextBox1.Text);
                                OperatorC = true;
                                richTextBox1.Clear();
                                ResultC = false;
                            }
                            catch (Exception ex)
                            {
                                SystemSounds.Asterisk.Play();
                                richTextBox1.Text = ex.ToString();
                            }
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                        }
                        break;
                    case "/":
                        if (ResultC == false && OperatorC == false)
                        {
                            try
                            {
                                OperationP = e.KeyChar.ToString();
                                lblValue.Text = (result / double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                                result = result / double.Parse(richTextBox1.Text);
                                OperatorC = true;
                                richTextBox1.Clear();
                                ResultC = false;
                            }
                            catch (Exception ex)
                            {
                                SystemSounds.Asterisk.Play();
                                richTextBox1.Text = ex.ToString();
                            }
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                        }
                        break;
                    default:
                        break;
                }
            }
        //END OF FUNCTION USED FOR KEY PRESS

            //NORMAL FUNCTION
                public void FirstClick()
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Clear();
            }
        }
                public void noPrev(object sender)
        {
            switch (OperationP)
            {
                case "+":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                            Button button = (Button)sender;
                            OperationP = button.Text;
                            lblValue.Text = (result + double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                            result = result + double.Parse(richTextBox1.Text);
                            OperatorC = true;
                            richTextBox1.Clear();
                            ResultC = false;
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    break;
                case "-":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                            Button button = (Button)sender;
                            OperationP = button.Text;
                            lblValue.Text = (result - double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                            result = result - double.Parse(richTextBox1.Text);
                            OperatorC = true;
                            richTextBox1.Clear();
                            ResultC = false;
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    break;
                case "*":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                            Button button = (Button)sender;
                            OperationP = button.Text;
                            lblValue.Text = (result * double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                            result = result * double.Parse(richTextBox1.Text);
                            OperatorC = true;
                            richTextBox1.Clear();
                            ResultC = false;
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    break;
                case "/":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                            Button button = (Button)sender;
                            OperationP = button.Text;
                            lblValue.Text = (result / double.Parse(richTextBox1.Text)).ToString() + " " + OperationP;
                            result = result / double.Parse(richTextBox1.Text);
                            OperatorC = true;
                            richTextBox1.Clear();
                            ResultC = false;
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    break;
                default:
                    break;
            }
        }
                public void btnclick(object sender)
        {
            try
            {
                if (OperatorC == true)
                    cntbut = cntbut + 1;

                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Clear();
                }
                if (Checkclear == true)
                {
                    richTextBox1.Clear();
                    lblValue.Text = "";
                    Checkclear = false;
                }

                Button button = (Button)sender;
                ResultC = false;
                OperatorC = false;
                richTextBox1.Text = richTextBox1.Text + button.Text;
            }
            catch (Exception ex)
            {
                SystemSounds.Asterisk.Play();
                richTextBox1.Text = ex.ToString();
            }

        }
                public void Prev(object sender)
        {
            try
            {
                if (OperatorC == false)
                {
                    Button button = (Button)sender;
                    OperationP = button.Text;
                    Checkclear = false;
                    result = double.Parse(richTextBox1.Text);

                    lblValue.Text = result + " " + OperationP;
                    richTextBox1.Clear();
                    OperatorC = true;
                    prev = true;

                    ResultC = false;
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Asterisk.Play();
                richTextBox1.Text = ex.ToString();
            }
        }
                public void Resultf()
        {
            cnt = cnt + 1;
            

            string oper;
            switch (OperationP)
            {

                case "+":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                           
                            lblValue.Text = "";
                            no1 = result;
                            oper = OperationP;
                            no2 = Double.Parse(richTextBox1.Text);
                            richTextBox1.Text = (result + double.Parse(richTextBox1.Text)).ToString();
                            resultfinal = double.Parse(richTextBox1.Text);
                            Checkclear = true;
                            OperatorC = false;
                            ResultC = true;
                            prev = false;
                            //button21.Visible = true;
                            History[cnt] = no1.ToString() + "  " + oper + "  " + no2.ToString() + "  =  " + resultfinal;
                        }
                        
                        catch (Exception e)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = e.ToString();
                        }
                    }
                    else if (ResultC == true)
                    {
                        try
                        { 
                            richTextBox1.Text = (Double.Parse(richTextBox1.Text) + no2).ToString();
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    break;
                case "-":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                           
                            lblValue.Text = "";
                            no1 = result;
                            oper = OperationP;
                            no2 = Double.Parse(richTextBox1.Text);
                            no2 = Double.Parse(richTextBox1.Text);
                            no2 = Double.Parse(richTextBox1.Text);
                            no2 = Double.Parse(richTextBox1.Text);
                            richTextBox1.Text = (result - double.Parse(richTextBox1.Text)).ToString();
                            resultfinal = double.Parse(richTextBox1.Text);
                            Checkclear = true;
                            OperatorC = false;
                            ResultC = true;
                            prev = false;
                            //button21.Visible = true;
                            History[cnt] = no1.ToString() + "  " + oper + "  " + no2.ToString() + "  =  " + resultfinal;
                        }
                        catch (Exception e)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = e.ToString();
                        }
                    }
                    else if (ResultC == true)
                    {
                        try
                        {
                            richTextBox1.Text = (Double.Parse(richTextBox1.Text) - no2).ToString();
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    break;
                case "*":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                           
                            lblValue.Text = "";
                            no1 = result;
                            oper = OperationP;
                            no2 = Double.Parse(richTextBox1.Text);
                            richTextBox1.Text = (result * double.Parse(richTextBox1.Text)).ToString();
                            resultfinal = double.Parse(richTextBox1.Text);
                            Checkclear = true;
                            OperatorC = false;
                            ResultC = true;
                            prev = false;
                            //button21.Visible = true;
                            History[cnt] = no1.ToString() + "  " + oper + "  " + no2.ToString() + "  =  " + resultfinal;
                        }
                        catch (Exception e)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = e.ToString();
                        }
                    }
                    else if (ResultC == true)
                    {

                        try
                        {
                            richTextBox1.Text = (Double.Parse(richTextBox1.Text) * no2).ToString();
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    break;
                case "/":
                    if (ResultC == false && OperatorC == false)
                    {
                        try
                        {
                          
                            lblValue.Text = "";
                            no1 = result;
                            oper = OperationP;
                            no2 = Double.Parse(richTextBox1.Text);
                            richTextBox1.Text = (result / double.Parse(richTextBox1.Text)).ToString();
                            resultfinal = double.Parse(richTextBox1.Text);
                            Checkclear = true;
                            OperatorC = false;
                            ResultC = true;
                            prev = false;
                            //button21.Visible = true;
                            History[cnt] = no1.ToString() + "  " + oper + "  " + no2.ToString() + "  =  " + resultfinal;
                        }
                        catch (Exception e)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = e.ToString();
                        }
                    }
                    else if (ResultC == true)
                    {

                        try
                        {
                            richTextBox1.Text = (Double.Parse(richTextBox1.Text) / no2).ToString();
                        }
                        catch (Exception ex)
                        {
                            SystemSounds.Asterisk.Play();
                            richTextBox1.Text = ex.ToString();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
                public void Delete()
        {
            try
            {
                richTextBox1.Clear();
                richTextBox1.Text = "0";
                result = 0;
                lblValue.Text = "";
            }
            catch (Exception ex)
            {
                SystemSounds.Asterisk.Play();
                richTextBox1.Text = ex.ToString();
            }
        }
                public void backSpace()
        {
            try
            {
                if (richTextBox1.Text == "" && lblValue.Text != "")
                {
                    lblValue.Text = "";
                    richTextBox1.Text = result.ToString();
                    prev = false;
                }
                else if (richTextBox1.Text == "0" && lblValue.Text != "")
                {
                    lblValue.Text = "";
                    richTextBox1.Text = result.ToString();
                    prev = false;
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
                    prev = false;
                }
                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = "0";
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Asterisk.Play();
                richTextBox1.Text = ex.ToString();
            }
        }
            //END OF NORMAL FUNCTION

        //END OF USER DEFINED METHODS

        //SYSTEM DEFINED METHODS
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            //button21.Visible = false;
            this.MaximizeBox = false;
            lblValue.Text = "";
            
            richTextBox1.Enabled = true;
        }
        
        
        
        private void ButtonsClick(object sender, EventArgs e)
        {
            btnclick(sender);
            //if(if)
            //label[cntbut] = (label[cntbut] + Double.Parse(richTextBox1.Text))-label[cntbut];
            //MessageBox.Show(label[cnt].ToString());
          


        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "0";
            result = 0;
            lblValue.Text = "";
        }
        
      
        
        private void OperatorClick(object sender, EventArgs e)
        {

            if (prev == false)
            {
                Prev(sender);
                
            }
            else
            {
                noPrev(sender);
                
            }
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resultf();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Delete();
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            backSpace();
            
            int timercount = i;
            while(timercount != i + 5)
            {
                button2.Font = new Font("Microsoft Sans Seriff", 14, FontStyle.Regular);
            }
            button2.Font = new Font("Microsoft Sans Seriff", 15, FontStyle.Regular);
            

        }
        public void hover(object sender)
        {
            

        }
        public void hoverleave(object sender)
        {
            
        }
        private void HoverButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //btn.Font = new Font("Microsoft Sans Seriff", 18, FontStyle.Regular);
            btn.BackColor = Color.Gray;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            
           

        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            //int no = 1;
            //while(no <= cnt)
            //{
            //    label2.Text += History[no] + "\n";

                
            //    no = no + 1;
            //}
        }
        private void button21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            History f = new History(History,cnt);
            f.Show();
            this.Hide();
        }
        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://tanishjlathi.whjr.site/");
            Process.Start(sInfo);
        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button button = (Button)sender;
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                richTextBox1.Text = button.Text;
            
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyboardPress(sender, e);
        }
        public void KeyboardPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46)
            {

                btnclick(e);
            }
            else if (e.KeyChar == 42 || e.KeyChar == 47 || e.KeyChar == 43 || e.KeyChar == 45)
            {
                if(prev == false)
                { 
                    Prev(e);    
                }
                else
                {
                    noPrev(e);
                }

            }
            else if (e.KeyChar == 61)
            {
               
                Resultf();
               
            }
            else if (e.KeyChar == 08)
            {

                backSpace();
            }
            else if (e.KeyChar.ToString() == "\r")
            {

               
                Resultf();
                
            }
            else if (e.KeyChar == 127)
            {

                Delete();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }
        }
             
        

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
        }

        private void ButtonsKeyClick(object sender, KeyPressEventArgs e)
        {
            KeyboardPress(sender, e);
        }

        private void OperatorKeyClick(object sender, KeyPressEventArgs e)
        {
            KeyboardPress(sender, e);
        }

        private void button13_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyboardPress(sender, e);
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyboardPress(sender, e);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyboardPress(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnEnter(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Resultf();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
            else if(e.KeyCode == Keys.Back)
            {
                this.backSpace();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Scientific(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                switch (button.Text)
                {
                    case "Sqr":
                        richTextBox1.Text = (Double.Parse(richTextBox1.Text) * Double.Parse(richTextBox1.Text)).ToString();
                        break;
                    case "Cube":
                        richTextBox1.Text = (Double.Parse(richTextBox1.Text) * Double.Parse(richTextBox1.Text) * Double.Parse(richTextBox1.Text)).ToString();
                        break;
                }
                
            }
            catch(Exception ex)
            {
                SystemSounds.Asterisk.Play();
                richTextBox1.Text = ex.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            History f = new History(History, cnt);
            f.Show();
            this.Hide();
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(275, 482);
        }

        private void HoverLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Microsoft Sans Seriff", 15, FontStyle.Regular);
            btn.BackColor = Color.DimGray;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            
        }
       
    }
}
