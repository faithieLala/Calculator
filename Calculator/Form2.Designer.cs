namespace Calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.BtnCot = new System.Windows.Forms.Button();
            this.btnBrack1 = new System.Windows.Forms.Button();
            this.btnBrack2 = new System.Windows.Forms.Button();
            this.BtnCsc = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnNum7 = new System.Windows.Forms.Button();
            this.BtnNum6 = new System.Windows.Forms.Button();
            this.BtnNum5 = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.BtnTimes = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnNum4 = new System.Windows.Forms.Button();
            this.BtnNum3 = new System.Windows.Forms.Button();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.BtnNum8 = new System.Windows.Forms.Button();
            this.BtnNum0 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnNum9 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 76);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(11, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(105, 33);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Basic Calc.";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.btnChange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSciCalc_MouseDown);
            this.btnChange.MouseEnter += new System.EventHandler(this.btnChange_MouseHover);
            this.btnChange.MouseLeave += new System.EventHandler(this.btnChange_MouseLeave);
            this.btnChange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSciCalc_MouseUp);
            // 
            // BtnSin
            // 
            this.BtnSin.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSin.Location = new System.Drawing.Point(12, 165);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(61, 45);
            this.BtnSin.TabIndex = 2;
            this.BtnSin.Text = "Sin";
            this.BtnSin.UseVisualStyleBackColor = true;
            this.BtnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCos.Location = new System.Drawing.Point(12, 216);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(61, 46);
            this.BtnCos.TabIndex = 3;
            this.BtnCos.Text = "Cos";
            this.BtnCos.UseVisualStyleBackColor = true;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnTan
            // 
            this.BtnTan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnTan.Location = new System.Drawing.Point(12, 268);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(61, 46);
            this.BtnTan.TabIndex = 4;
            this.BtnTan.Text = "Tan";
            this.BtnTan.UseVisualStyleBackColor = true;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // BtnCot
            // 
            this.BtnCot.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCot.Location = new System.Drawing.Point(12, 320);
            this.BtnCot.Name = "BtnCot";
            this.BtnCot.Size = new System.Drawing.Size(61, 48);
            this.BtnCot.TabIndex = 5;
            this.BtnCot.Text = "Cot";
            this.BtnCot.UseVisualStyleBackColor = true;
            this.BtnCot.Click += new System.EventHandler(this.BtnCot_Click);
            // 
            // btnBrack1
            // 
            this.btnBrack1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrack1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrack1.Location = new System.Drawing.Point(12, 119);
            this.btnBrack1.Name = "btnBrack1";
            this.btnBrack1.Size = new System.Drawing.Size(61, 40);
            this.btnBrack1.TabIndex = 6;
            this.btnBrack1.Text = "(";
            this.btnBrack1.UseVisualStyleBackColor = true;
            this.btnBrack1.Click += new System.EventHandler(this.btnBrack1_Click);
            // 
            // btnBrack2
            // 
            this.btnBrack2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrack2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrack2.Location = new System.Drawing.Point(79, 119);
            this.btnBrack2.Name = "btnBrack2";
            this.btnBrack2.Size = new System.Drawing.Size(60, 40);
            this.btnBrack2.TabIndex = 7;
            this.btnBrack2.Text = ")";
            this.btnBrack2.UseVisualStyleBackColor = true;
            this.btnBrack2.Click += new System.EventHandler(this.btnBrack2_Click);
            // 
            // BtnCsc
            // 
            this.BtnCsc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCsc.Location = new System.Drawing.Point(79, 165);
            this.BtnCsc.Name = "BtnCsc";
            this.BtnCsc.Size = new System.Drawing.Size(60, 45);
            this.BtnCsc.TabIndex = 8;
            this.BtnCsc.Text = "Csc";
            this.BtnCsc.UseVisualStyleBackColor = true;
            this.BtnCsc.Click += new System.EventHandler(this.BtnCsc_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPercent.Location = new System.Drawing.Point(79, 216);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(60, 46);
            this.BtnPercent.TabIndex = 9;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            this.BtnPercent.Click += new System.EventHandler(this.BtnPercent_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPlus.Location = new System.Drawing.Point(79, 268);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(60, 46);
            this.BtnPlus.TabIndex = 10;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMinus.Location = new System.Drawing.Point(79, 320);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(60, 48);
            this.BtnMinus.TabIndex = 11;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnNum7
            // 
            this.BtnNum7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum7.Location = new System.Drawing.Point(241, 216);
            this.BtnNum7.Name = "BtnNum7";
            this.BtnNum7.Size = new System.Drawing.Size(56, 46);
            this.BtnNum7.TabIndex = 12;
            this.BtnNum7.Text = "7";
            this.BtnNum7.UseVisualStyleBackColor = true;
            this.BtnNum7.Click += new System.EventHandler(this.BtnNum7_Click);
            // 
            // BtnNum6
            // 
            this.BtnNum6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum6.Location = new System.Drawing.Point(365, 165);
            this.BtnNum6.Name = "BtnNum6";
            this.BtnNum6.Size = new System.Drawing.Size(53, 45);
            this.BtnNum6.TabIndex = 13;
            this.BtnNum6.Text = "6";
            this.BtnNum6.UseVisualStyleBackColor = true;
            this.BtnNum6.Click += new System.EventHandler(this.BtnNum6_Click);
            // 
            // BtnNum5
            // 
            this.BtnNum5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum5.Location = new System.Drawing.Point(303, 165);
            this.BtnNum5.Name = "BtnNum5";
            this.BtnNum5.Size = new System.Drawing.Size(56, 45);
            this.BtnNum5.TabIndex = 14;
            this.BtnNum5.Text = "5";
            this.BtnNum5.UseVisualStyleBackColor = true;
            this.BtnNum5.Click += new System.EventHandler(this.BtnNum5_Click);
            // 
            // btnAc
            // 
            this.btnAc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAc.Location = new System.Drawing.Point(145, 119);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(61, 40);
            this.btnAc.TabIndex = 15;
            this.btnAc.Text = "AC";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // BtnTimes
            // 
            this.BtnTimes.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnTimes.Location = new System.Drawing.Point(145, 268);
            this.BtnTimes.Name = "BtnTimes";
            this.BtnTimes.Size = new System.Drawing.Size(61, 45);
            this.BtnTimes.TabIndex = 16;
            this.BtnTimes.Text = "x";
            this.BtnTimes.UseVisualStyleBackColor = true;
            this.BtnTimes.Click += new System.EventHandler(this.BtnTimes_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDivide.Location = new System.Drawing.Point(145, 216);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(61, 46);
            this.BtnDivide.TabIndex = 17;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnNum4
            // 
            this.BtnNum4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum4.Location = new System.Drawing.Point(241, 165);
            this.BtnNum4.Name = "BtnNum4";
            this.BtnNum4.Size = new System.Drawing.Size(56, 45);
            this.BtnNum4.TabIndex = 18;
            this.BtnNum4.Text = "4";
            this.BtnNum4.UseVisualStyleBackColor = true;
            this.BtnNum4.Click += new System.EventHandler(this.BtnNum4_Click);
            // 
            // BtnNum3
            // 
            this.BtnNum3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum3.Location = new System.Drawing.Point(365, 119);
            this.BtnNum3.Name = "BtnNum3";
            this.BtnNum3.Size = new System.Drawing.Size(53, 40);
            this.BtnNum3.TabIndex = 19;
            this.BtnNum3.Text = "3";
            this.BtnNum3.UseVisualStyleBackColor = true;
            this.BtnNum3.Click += new System.EventHandler(this.BtnNum3_Click);
            // 
            // BtnNum2
            // 
            this.BtnNum2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum2.Location = new System.Drawing.Point(303, 119);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(56, 40);
            this.BtnNum2.TabIndex = 20;
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = true;
            this.BtnNum2.Click += new System.EventHandler(this.BtnNum2_Click);
            // 
            // BtnNum1
            // 
            this.BtnNum1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum1.Location = new System.Drawing.Point(241, 119);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(56, 40);
            this.BtnNum1.TabIndex = 21;
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = true;
            this.BtnNum1.Click += new System.EventHandler(this.BtnNum1_Click);
            // 
            // BtnNum8
            // 
            this.BtnNum8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum8.Location = new System.Drawing.Point(303, 216);
            this.BtnNum8.Name = "BtnNum8";
            this.BtnNum8.Size = new System.Drawing.Size(56, 46);
            this.BtnNum8.TabIndex = 22;
            this.BtnNum8.Text = "8";
            this.BtnNum8.UseVisualStyleBackColor = true;
            this.BtnNum8.Click += new System.EventHandler(this.BtnNum8_Click);
            // 
            // BtnNum0
            // 
            this.BtnNum0.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum0.Location = new System.Drawing.Point(241, 268);
            this.BtnNum0.Name = "BtnNum0";
            this.BtnNum0.Size = new System.Drawing.Size(118, 46);
            this.BtnNum0.TabIndex = 23;
            this.BtnNum0.Text = "0";
            this.BtnNum0.UseVisualStyleBackColor = true;
            this.BtnNum0.Click += new System.EventHandler(this.BtnNum0_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDot.Location = new System.Drawing.Point(365, 268);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(53, 46);
            this.BtnDot.TabIndex = 24;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // BtnNum9
            // 
            this.BtnNum9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNum9.Location = new System.Drawing.Point(365, 216);
            this.BtnNum9.Name = "BtnNum9";
            this.BtnNum9.Size = new System.Drawing.Size(53, 46);
            this.BtnNum9.TabIndex = 25;
            this.BtnNum9.Text = "9";
            this.BtnNum9.UseVisualStyleBackColor = true;
            this.BtnNum9.Click += new System.EventHandler(this.BtnNum9_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEquals.Location = new System.Drawing.Point(145, 320);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(152, 48);
            this.BtnEquals.TabIndex = 26;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 35);
            this.label2.TabIndex = 27;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(430, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnNum9);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnNum0);
            this.Controls.Add(this.BtnNum8);
            this.Controls.Add(this.BtnNum1);
            this.Controls.Add(this.BtnNum2);
            this.Controls.Add(this.BtnNum3);
            this.Controls.Add(this.BtnNum4);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnTimes);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.BtnNum5);
            this.Controls.Add(this.BtnNum6);
            this.Controls.Add(this.BtnNum7);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnCsc);
            this.Controls.Add(this.btnBrack2);
            this.Controls.Add(this.btnBrack1);
            this.Controls.Add(this.BtnCot);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.textBox2);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button BtnSin;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnTan;
        private System.Windows.Forms.Button BtnCot;
        private System.Windows.Forms.Button btnBrack1;
        private System.Windows.Forms.Button btnBrack2;
        private System.Windows.Forms.Button BtnCsc;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnNum7;
        private System.Windows.Forms.Button BtnNum6;
        private System.Windows.Forms.Button BtnNum5;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button BtnTimes;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnNum4;
        private System.Windows.Forms.Button BtnNum3;
        private System.Windows.Forms.Button BtnNum2;
        private System.Windows.Forms.Button BtnNum1;
        private System.Windows.Forms.Button BtnNum8;
        private System.Windows.Forms.Button BtnNum0;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnNum9;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Label label2;

    }
}