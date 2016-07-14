using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        string contain;
        string contain1;
        string contain3;
        string contain4;
        bool plusEnabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "1";
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "2";
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "3";
            }
            else {
                label1.Text += "3";
            }
            }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "4";
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "5";
            }
            else
            {
                label1.Text += "5";
            }
            
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                txtBox1.Text += "0";
            }
            else
            {
                label1.Text += "0";
            }
            //Button Num0 = (Button)sender;
            //MessageBox.Show(num0.Name);
            //string Num = Num0.Name.Replace("btnNum0", "");
            //txtBox1.Text += Num;


            

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            if ( txtBox1.Text != "")
            {
                contain = txtBox1.Text;
                label1.Text += "+";
                plusEnabled = true;
            }

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //string contain2 = label1.Text.in
            string contain2 = label1.Text.Remove(0, 1);
            //foreach (var item in collection)
            //{
                
            //}
            label1.Text = "";

            int Num1;
            int Num2;

            if (int.TryParse(contain1, out Num1) && (int.TryParse(contain2, out Num2)))
            {
                int result = int.Parse(contain1) + int.Parse(contain2); //+ int.Parse(contain5);              
                txtBox1.Text = result.ToString();
                plusEnabled = false;
                
            }
            else if(int.TryParse(contain1, out Num1) && (int.TryParse(contain2, out Num2)))
            {
                int result = int.Parse(contain1) * int.Parse(contain2);
                txtBox1.Text = result.ToString();
                plusEnabled = false;
            }
            else if (int.TryParse(contain1, out Num1) && (int.TryParse(contain2, out Num2)))
            {
                int result = int.Parse(contain1) / int.Parse(contain2);
                txtBox1.Text = result.ToString();
                plusEnabled = false;
            }
            else if (int.TryParse(contain1, out Num1) && (int.TryParse(contain2, out Num2)))
            {
                

                int result = int.Parse(contain4) - int.Parse(contain2);
                txtBox1.Text = result.ToString();
                plusEnabled = false;
                
             
            }

        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" && (txtBox1.Text != ""))
            {
                contain1 = txtBox1.Text;
                label1.Text += "x";
                plusEnabled = true;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" && (txtBox1.Text != ""))
            {
                contain3 = txtBox1.Text;
                label1.Text += "/";
                plusEnabled = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" && (txtBox1.Text != ""))
            {
                contain4 = txtBox1.Text;
                label1.Text += "-";
                plusEnabled = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
                txtBox1.Text = "";
                label1.Text = "";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Manipulate man = new Manipulate();
            //man.manipulation(this);
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form2)
                {
                    frm.Show();
                    return;
                }
            }
            Form2 fo = new Form2();
            fo.Show();
        }

        private void btnSciCalc_MouseEnter(object sender, EventArgs e)
        {
            btnSciCalc.BackColor = Color.LightBlue;
        }

        private void btnSciCalc_MouseLeave(object sender, EventArgs e)
        {
            btnSciCalc.BackColor = Color.FloralWhite;
        }

        private void btnSciCalc_MouseDown(object sender, MouseEventArgs e)
        {
            btnSciCalc.BackColor = Color.BlueViolet;
        }

        private void btnSciCalc_MouseUp(object sender, MouseEventArgs e)
        {
            btnSciCalc.BackColor = Color.FloralWhite;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
       
    }
}
