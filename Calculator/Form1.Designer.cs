namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Parentheses = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            textBox_Result = new TextBox();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // Parentheses
            // 
            Parentheses.BackColor = Color.Black;
            Parentheses.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Parentheses.ForeColor = SystemColors.ControlLightLight;
            Parentheses.Location = new Point(12, 117);
            Parentheses.Name = "Parentheses";
            Parentheses.Size = new Size(53, 45);
            Parentheses.TabIndex = 0;
            Parentheses.Text = "( )";
            Parentheses.UseVisualStyleBackColor = false;
            Parentheses.Click += parentheses_click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(248, 117);
            button8.Name = "button8";
            button8.Size = new Size(53, 45);
            button8.TabIndex = 8;
            button8.Text = "sin";
            button8.UseVisualStyleBackColor = false;
            button8.Click += sin_click;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(189, 117);
            button9.Name = "button9";
            button9.Size = new Size(53, 45);
            button9.TabIndex = 9;
            button9.Text = "xʸ";
            button9.UseVisualStyleBackColor = false;
            button9.Click += operator_click;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(130, 117);
            button10.Name = "button10";
            button10.Size = new Size(53, 45);
            button10.TabIndex = 10;
            button10.Text = "x³";
            button10.UseVisualStyleBackColor = false;
            button10.Click += cube_click;
            // 
            // button11
            // 
            button11.BackColor = Color.Black;
            button11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(71, 117);
            button11.Name = "button11";
            button11.Size = new Size(53, 45);
            button11.TabIndex = 11;
            button11.Text = "x²";
            button11.UseVisualStyleBackColor = false;
            button11.Click += square_click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(71, 168);
            button1.Name = "button1";
            button1.Size = new Size(53, 44);
            button1.TabIndex = 17;
            button1.Text = "e";
            button1.UseVisualStyleBackColor = false;
            button1.Click += e_click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(130, 168);
            button2.Name = "button2";
            button2.Size = new Size(53, 44);
            button2.TabIndex = 16;
            button2.Text = "∛y";
            button2.UseVisualStyleBackColor = false;
            button2.Click += cubeRoot_click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(189, 168);
            button3.Name = "button3";
            button3.Size = new Size(53, 44);
            button3.TabIndex = 15;
            button3.Text = "√x";
            button3.UseVisualStyleBackColor = false;
            button3.Click += sqr_click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(248, 168);
            button4.Name = "button4";
            button4.Size = new Size(53, 44);
            button4.TabIndex = 14;
            button4.Text = "x!";
            button4.UseVisualStyleBackColor = false;
            button4.Click += factorial_click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(12, 168);
            button6.Name = "button6";
            button6.Size = new Size(53, 44);
            button6.TabIndex = 12;
            button6.Text = "ln";
            button6.UseVisualStyleBackColor = false;
            button6.Click += ln_click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(307, 168);
            button5.Name = "button5";
            button5.Size = new Size(53, 44);
            button5.TabIndex = 13;
            button5.Text = "tan";
            button5.UseVisualStyleBackColor = false;
            button5.Click += tan_click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(307, 117);
            button7.Name = "button7";
            button7.Size = new Size(53, 45);
            button7.TabIndex = 7;
            button7.Text = "cos";
            button7.UseVisualStyleBackColor = false;
            button7.Click += cos_click;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkOrange;
            button12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(270, 229);
            button12.Name = "button12";
            button12.Size = new Size(90, 41);
            button12.TabIndex = 20;
            button12.Text = "÷";
            button12.UseVisualStyleBackColor = false;
            button12.Click += operator_click;
            // 
            // button13
            // 
            button13.BackColor = Color.Gray;
            button13.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(12, 229);
            button13.Name = "button13";
            button13.Size = new Size(80, 41);
            button13.TabIndex = 21;
            button13.Text = "CE";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Gray;
            button14.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(98, 229);
            button14.Name = "button14";
            button14.Size = new Size(80, 41);
            button14.TabIndex = 22;
            button14.Text = "C";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Gray;
            button15.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(184, 229);
            button15.Name = "button15";
            button15.Size = new Size(80, 41);
            button15.TabIndex = 23;
            button15.Text = "%";
            button15.UseVisualStyleBackColor = false;
            button15.Click += percent_click;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkOrange;
            button16.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(270, 370);
            button16.Name = "button16";
            button16.Size = new Size(90, 41);
            button16.TabIndex = 24;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = false;
            button16.Click += operator_click;
            // 
            // button17
            // 
            button17.BackColor = Color.DarkOrange;
            button17.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button17.ForeColor = SystemColors.ControlLightLight;
            button17.Location = new Point(270, 323);
            button17.Name = "button17";
            button17.Size = new Size(90, 41);
            button17.TabIndex = 25;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = false;
            button17.Click += operator_click;
            // 
            // button18
            // 
            button18.BackColor = Color.DarkOrange;
            button18.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button18.ForeColor = SystemColors.ControlLightLight;
            button18.Location = new Point(270, 276);
            button18.Name = "button18";
            button18.Size = new Size(90, 41);
            button18.TabIndex = 26;
            button18.Text = "*";
            button18.UseVisualStyleBackColor = false;
            button18.Click += operator_click;
            // 
            // button19
            // 
            button19.BackColor = Color.DarkOrange;
            button19.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button19.ForeColor = SystemColors.ControlLightLight;
            button19.Location = new Point(270, 417);
            button19.Name = "button19";
            button19.Size = new Size(90, 41);
            button19.TabIndex = 27;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(64, 64, 64);
            button20.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button20.ForeColor = SystemColors.ControlLightLight;
            button20.Location = new Point(184, 323);
            button20.Name = "button20";
            button20.Size = new Size(80, 41);
            button20.TabIndex = 30;
            button20.Text = "6";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button_click;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(64, 64, 64);
            button21.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button21.ForeColor = SystemColors.ControlLightLight;
            button21.Location = new Point(98, 323);
            button21.Name = "button21";
            button21.Size = new Size(80, 41);
            button21.TabIndex = 29;
            button21.Text = "5";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button_click;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(64, 64, 64);
            button22.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button22.ForeColor = SystemColors.ControlLightLight;
            button22.Location = new Point(12, 323);
            button22.Name = "button22";
            button22.Size = new Size(80, 41);
            button22.TabIndex = 28;
            button22.Text = "4";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button_click;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(64, 64, 64);
            button23.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button23.ForeColor = SystemColors.ControlLightLight;
            button23.Location = new Point(184, 370);
            button23.Name = "button23";
            button23.Size = new Size(80, 41);
            button23.TabIndex = 33;
            button23.Text = "3";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button_click;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(64, 64, 64);
            button24.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button24.ForeColor = SystemColors.ControlLightLight;
            button24.Location = new Point(98, 370);
            button24.Name = "button24";
            button24.Size = new Size(80, 41);
            button24.TabIndex = 32;
            button24.Text = "2";
            button24.UseVisualStyleBackColor = false;
            button24.Click += button_click;
            // 
            // button25
            // 
            button25.BackColor = Color.FromArgb(64, 64, 64);
            button25.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button25.ForeColor = SystemColors.ControlLightLight;
            button25.Location = new Point(12, 370);
            button25.Name = "button25";
            button25.Size = new Size(80, 41);
            button25.TabIndex = 31;
            button25.Text = "1";
            button25.UseVisualStyleBackColor = false;
            button25.Click += button_click;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(64, 64, 64);
            button26.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button26.ForeColor = SystemColors.ControlLightLight;
            button26.Location = new Point(184, 417);
            button26.Name = "button26";
            button26.Size = new Size(80, 41);
            button26.TabIndex = 36;
            button26.Text = ".";
            button26.UseVisualStyleBackColor = false;
            button26.Click += button_click;
            // 
            // button27
            // 
            button27.BackColor = Color.FromArgb(64, 64, 64);
            button27.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button27.ForeColor = SystemColors.ControlLightLight;
            button27.Location = new Point(98, 417);
            button27.Name = "button27";
            button27.Size = new Size(80, 41);
            button27.TabIndex = 35;
            button27.Text = "0";
            button27.UseVisualStyleBackColor = false;
            button27.Click += button_click;
            // 
            // button28
            // 
            button28.BackColor = Color.FromArgb(64, 64, 64);
            button28.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button28.ForeColor = SystemColors.ControlLightLight;
            button28.Location = new Point(12, 417);
            button28.Name = "button28";
            button28.Size = new Size(80, 41);
            button28.TabIndex = 34;
            button28.Text = "±";
            button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = Color.FromArgb(64, 64, 64);
            button29.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button29.ForeColor = SystemColors.ControlLightLight;
            button29.Location = new Point(184, 277);
            button29.Name = "button29";
            button29.Size = new Size(80, 41);
            button29.TabIndex = 39;
            button29.Text = "9";
            button29.UseVisualStyleBackColor = false;
            button29.Click += button_click;
            // 
            // button30
            // 
            button30.BackColor = Color.FromArgb(64, 64, 64);
            button30.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button30.ForeColor = SystemColors.ControlLightLight;
            button30.Location = new Point(98, 277);
            button30.Name = "button30";
            button30.Size = new Size(80, 41);
            button30.TabIndex = 38;
            button30.Text = "8";
            button30.UseVisualStyleBackColor = false;
            button30.Click += button_click;
            // 
            // button31
            // 
            button31.BackColor = Color.FromArgb(64, 64, 64);
            button31.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button31.ForeColor = SystemColors.ControlLightLight;
            button31.Location = new Point(12, 277);
            button31.Name = "button31";
            button31.Size = new Size(80, 41);
            button31.TabIndex = 37;
            button31.Text = "7";
            button31.UseVisualStyleBackColor = false;
            button31.Click += button_click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(12, 54);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(348, 42);
            textBox_Result.TabIndex = 40;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCurrentOperation.ForeColor = SystemColors.ButtonShadow;
            labelCurrentOperation.Location = new Point(12, 18);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 22);
            labelCurrentOperation.TabIndex = 41;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 470);
            Controls.Add(labelCurrentOperation);
            Controls.Add(textBox_Result);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(button31);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(Parentheses);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danny-Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Parentheses;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private TextBox textBox_Result;
        private Label labelCurrentOperation;
    }
}
