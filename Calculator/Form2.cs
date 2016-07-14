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
    public partial class Form2 : Form
    {
        string contain;
        string contain1;
        string contain3;
        string contain4;
        string contain6;
        string conta6;
        
        double contain7;
        double contain9;
        double contain11;
        bool plusEnabled = false;
        bool brackenabled = false;
        bool tanEnabled;
        bool cosEnabled;
        bool sinEnabled = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                    return;
                }
            }
        }

        private void btnChange_MouseHover(object sender, System.EventArgs e)
        {
            btnChange.BackColor = Color.LightBlue;
        }
        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "1";

            }
            else
            {
                label2.Text += "1";
            }
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "2";
            }
            else
            {
                label2.Text += "2";
            }
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "3";
            }
            else
            {
                label2.Text += "3";
            }
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "4";
            }
            else
            {
                label2.Text += "4";
            }
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "5";
            }
            else
            {
                label2.Text += "5";
            }
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "6";
            }
            else
            {
                label2.Text += "6";
            }
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "7";
            }
            else
            {
                label2.Text += "7";
            }
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "8";
            }
            else
            {
                label2.Text += "8";
            }
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "9";
            }
            else
            {
                label2.Text += "9";
            }
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += "0";
            }
            else
            {
                label2.Text += "0";
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!plusEnabled)
            {
                textBox2.Text += ".";
            }
            else
            {
                label2.Text += ".";
            }
        }

        private void btnBrack1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "(";
        }

        private void btnBrack2_Click(object sender, EventArgs e)
        {
            textBox2.Text += ")";
            brackenabled = true;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {

                textBox2.Clear();
                label2.Text = "";
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            sinEnabled = true;
            textBox2.Text += "Sin (";
        }

        private void BtnCsc_Click(object sender, EventArgs e)
        {
            textBox2.Text += "Cosec";
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            cosEnabled = true;
            textBox2.Text += "Cos (";
            if (textBox2.Text == "Cos (") //&& textBox2.Text == "Cos(")
                contain6 = (textBox2.Text);
   
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            textBox2.Text += "%";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (label2.Text == "" && (textBox2.Text != ""))
            {
                contain3 = textBox2.Text;
                label2.Text += "/";
                plusEnabled = true;
            }
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            tanEnabled = true;
            textBox2.Text = "Tan (";
            
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (label2.Text == "" && (textBox2.Text != ""))
            {
                contain = textBox2.Text;
                label2.Text += "+";
                plusEnabled = true;
            }
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            if (label2.Text == "" && (textBox2.Text != ""))
            {
                contain1 = textBox2.Text;
                label2.Text += "x";
                plusEnabled = true;
            }
        }

        private void BtnCot_Click(object sender, EventArgs e)
        {
            textBox2.Text += "Cot";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (label2.Text == "" && (textBox2.Text != ""))
            {
                contain4 = textBox2.Text;
                label2.Text += "-";
                plusEnabled = true;
            }
        }



        private void BtnEquals_Click(object sender, EventArgs e)
        {
            int Num1;
            int Num2;
            double Num3;
            double Num4;
            double Num5;
            double Num6;
           




            if (int.TryParse(contain, out Num1) && (int.TryParse(contain, out Num2)))
            {
                string contain2 = label2.Text.Remove(0, 1);
                label2.Text = "";
                int result = int.Parse(contain) + int.Parse(contain2);              
                textBox2.Text = result.ToString();
                plusEnabled = false;
                
            }
            else if(int.TryParse(contain1, out Num1) && (int.TryParse(contain1, out Num2)))
            {
                string contain2 = label2.Text.Remove(0, 1);
                label2.Text = "";
                int result = int.Parse(contain1) * int.Parse(contain2);
                textBox2.Text = result.ToString();
                plusEnabled = false;
            }
            else if (int.TryParse(contain3, out Num1) && (int.TryParse(contain3, out Num2)))
            {
                string contain2 = label2.Text.Remove(0, 1);
                label2.Text = "";
                int result = int.Parse(contain3) / int.Parse(contain2);
                textBox2.Text = result.ToString();
                plusEnabled = false;
            }
            else if (int.TryParse(contain4, out Num1)  && (int.TryParse(contain4, out Num2)))
            {

                string contain2 = label2.Text.Remove(0, 1);
                label2.Text = "";
                int result = int.Parse(contain4) - int.Parse(contain2);
                textBox2.Text = result.ToString();
                plusEnabled = false;
            }



            if (cosEnabled == true && tanEnabled == false && sinEnabled == false)
            {
                if (textBox2.Text.Contains("Cos (") && textBox2.Text.Contains(")"))
                {
                    string cont = textBox2.Text.Remove(0, 5);
                    cont = (textBox2.Text.Length - 2).ToString();
                    double contain8 = double.Parse(cont);

                    //textBox2.Text = "";
                    double result = Math.Cos(contain8);
                    textBox2.Text = result.ToString();
                    //plusEnabled = false;
                }
                else if (textBox2.Text.Contains("Cos (") || textBox2.Text.Contains(")"))
                {
                    string cont = textBox2.Text.Remove(0, 5);
                    cont = (textBox2.Text.Length - 1).ToString();
                    double contain8 = double.Parse(cont);

                    textBox2.Text = "";
                    double result = Math.Cos(contain8);
                    textBox2.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Agurment");
                }

            }

            else if (tanEnabled == true)
            {
                if (textBox2.Text.Contains("Tan (") && textBox2.Text.Contains(")"))
                {
                    string conta = textBox2.Text.Remove(0, 5);
                    conta = (textBox2.Text.Length - 2).ToString();
                    double contain12 = double.Parse(conta);

                    //textBox2.Text = "";
                    double result = Math.Tan(contain12);
                    textBox2.Text = result.ToString();
                }
                else if (textBox2.Text.Contains("Tan (") || textBox2.Text.Contains(")"))
                {
                    string conta = textBox2.Text.Remove(0, 5);
                    // conta = (textBox2.Text.Length - 2).ToString();
                    double contain12 = double.Parse(conta);

                    //textBox2.Text = "";
                    double result = Math.Tan(contain12);
                    textBox2.Text = result.ToString();

                }
                else
                {
                    MessageBox.Show("Invalid Agurment");
                }
            }

                 else if (sinEnabled)
            {
                if (textBox2.Text.Contains("Sin (") && textBox2.Text.Contains(")"))
                {
                string conta3 = textBox2.Text.Remove(0, 5); 

                //textBox2.Text = "";
                conta3 = (textBox2.Text.Length - 2).ToString();
                double contain5 = double.Parse(conta3);

                double result = Math.Sin(contain5); //Math.Cos(contain5);
                textBox2.Text = result.ToString();
                //plusEnabled = false;
                }
                else if (textBox2.Text.Contains("Sin (") && textBox2.Text.Contains(")"))
                {
                    string conta3 = textBox2.Text.Remove(0, 5);

                    //textBox2.Text = "";
                    //conta3 = (textBox2.Text.Length - 2).ToString();
                    double contain5 = double.Parse(conta3);

                    double result = Math.Sin(contain5); //Math.Cos(contain5);
                    textBox2.Text = result.ToString();
                }

                else
                {
                    MessageBox.Show("Invalid Agurment");
                }
            }

            else 
            {
                MessageBox.Show("Invalid Agurment");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            btnChange.BackColor = Color.FloralWhite;
        }

        private void btnSciCalc_MouseDown(object sender, MouseEventArgs e)
        {
            btnChange.BackColor = Color.BlueViolet;
        }

        private void btnSciCalc_MouseUp(object sender, MouseEventArgs e)
        {
            btnChange.BackColor = Color.FloralWhite;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
