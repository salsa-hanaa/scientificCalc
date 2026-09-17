namespace CalculatorApp
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
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
            lstHistory = new ListBox();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dutch801 XBd BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 48);
            label1.TabIndex = 0;
            label1.Text = "Scientific Calculator";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 47);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 209);
            button1.Name = "button1";
            button1.Size = new Size(76, 63);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(106, 209);
            button2.Name = "button2";
            button2.Size = new Size(76, 63);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(188, 209);
            button3.Name = "button3";
            button3.Size = new Size(76, 63);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Pink;
            button4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(352, 209);
            button4.Name = "button4";
            button4.Size = new Size(112, 63);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += OperatorButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Pink;
            button5.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(352, 278);
            button5.Name = "button5";
            button5.Size = new Size(112, 63);
            button5.TabIndex = 6;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = false;
            button5.Click += OperatorButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Pink;
            button6.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(352, 347);
            button6.Name = "button6";
            button6.Size = new Size(112, 63);
            button6.TabIndex = 7;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = false;
            button6.Click += OperatorButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Pink;
            button7.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(352, 416);
            button7.Name = "button7";
            button7.Size = new Size(112, 63);
            button7.TabIndex = 8;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = false;
            button7.Click += OperatorButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.HotPink;
            button8.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(24, 485);
            button8.Name = "button8";
            button8.Size = new Size(359, 63);
            button8.TabIndex = 9;
            button8.Text = "=";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnEquals_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MistyRose;
            button9.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(188, 278);
            button9.Name = "button9";
            button9.Size = new Size(76, 63);
            button9.TabIndex = 10;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.MistyRose;
            button10.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(188, 347);
            button10.Name = "button10";
            button10.Size = new Size(76, 63);
            button10.TabIndex = 11;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            button10.Click += NumberButton_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.MistyRose;
            button11.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(106, 278);
            button11.Name = "button11";
            button11.Size = new Size(76, 63);
            button11.TabIndex = 12;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            button11.Click += NumberButton_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.MistyRose;
            button12.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(24, 278);
            button12.Name = "button12";
            button12.Size = new Size(76, 63);
            button12.TabIndex = 13;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += NumberButton_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.MistyRose;
            button13.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(106, 347);
            button13.Name = "button13";
            button13.Size = new Size(76, 63);
            button13.TabIndex = 14;
            button13.Text = "8";
            button13.UseVisualStyleBackColor = false;
            button13.Click += NumberButton_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.MistyRose;
            button14.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Location = new Point(24, 347);
            button14.Name = "button14";
            button14.Size = new Size(76, 63);
            button14.TabIndex = 15;
            button14.Text = "7";
            button14.UseVisualStyleBackColor = false;
            button14.Click += NumberButton_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.MistyRose;
            button15.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.Location = new Point(24, 416);
            button15.Name = "button15";
            button15.Size = new Size(76, 63);
            button15.TabIndex = 16;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = false;
            button15.Click += NumberButton_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.MistyRose;
            button16.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Location = new Point(106, 416);
            button16.Name = "button16";
            button16.Size = new Size(76, 63);
            button16.TabIndex = 17;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnDecimal_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.LightCoral;
            button17.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(388, 485);
            button17.Name = "button17";
            button17.Size = new Size(76, 63);
            button17.TabIndex = 18;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnClear_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Pink;
            button18.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Location = new Point(352, 140);
            button18.Name = "button18";
            button18.Size = new Size(112, 63);
            button18.TabIndex = 22;
            button18.Text = "⌫";
            button18.UseVisualStyleBackColor = false;
            button18.Click += btnBackspace_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Pink;
            button19.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button19.Location = new Point(270, 140);
            button19.Name = "button19";
            button19.Size = new Size(76, 63);
            button19.TabIndex = 21;
            button19.Text = "mod";
            button19.UseVisualStyleBackColor = false;
            button19.Click += OperatorButton_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Pink;
            button20.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button20.Location = new Point(188, 140);
            button20.Name = "button20";
            button20.Size = new Size(76, 63);
            button20.TabIndex = 20;
            button20.Text = "yˣ";
            button20.UseVisualStyleBackColor = false;
            button20.Click += OperatorButton_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Pink;
            button21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button21.Location = new Point(106, 140);
            button21.Name = "button21";
            button21.Size = new Size(76, 63);
            button21.TabIndex = 19;
            button21.Text = "logᵧx";
            button21.UseVisualStyleBackColor = false;
            button21.Click += OperatorButton_Click;
            // 
            // lstHistory
            // 
            lstHistory.BackColor = Color.SeaShell;
            lstHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstHistory.Location = new Point(470, 78);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(125, 464);
            lstHistory.TabIndex = 23;
            lstHistory.SelectedIndexChanged += lstHistory_SelectedIndexChanged;
            // 
            // button23
            // 
            button23.BackColor = Color.Pink;
            button23.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button23.Location = new Point(24, 140);
            button23.Name = "button23";
            button23.Size = new Size(76, 63);
            button23.TabIndex = 28;
            button23.Text = "ʸ√x";
            button23.UseVisualStyleBackColor = false;
            button23.Click += OperatorButton_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.Pink;
            button24.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button24.Location = new Point(188, 416);
            button24.Name = "button24";
            button24.Size = new Size(76, 63);
            button24.TabIndex = 27;
            button24.Text = "(";
            button24.UseVisualStyleBackColor = false;
            button24.Click += btnParenthesis_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.Pink;
            button25.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button25.Location = new Point(270, 347);
            button25.Name = "button25";
            button25.Size = new Size(76, 63);
            button25.TabIndex = 26;
            button25.Text = "e";
            button25.UseVisualStyleBackColor = false;
            button25.Click += btnE_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.Pink;
            button26.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button26.Location = new Point(270, 278);
            button26.Name = "button26";
            button26.Size = new Size(76, 63);
            button26.TabIndex = 25;
            button26.Text = "π";
            button26.UseVisualStyleBackColor = false;
            button26.Click += btnPi_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.Pink;
            button27.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button27.Location = new Point(270, 209);
            button27.Name = "button27";
            button27.Size = new Size(76, 63);
            button27.TabIndex = 24;
            button27.Text = "n!";
            button27.UseVisualStyleBackColor = false;
            button27.Click += btnFactorial_Click;
            // 
            // button28
            // 
            button28.BackColor = Color.Pink;
            button28.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button28.Location = new Point(270, 416);
            button28.Name = "button28";
            button28.Size = new Size(76, 63);
            button28.TabIndex = 29;
            button28.Text = ")";
            button28.UseVisualStyleBackColor = false;
            button28.Click += btnParenthesis_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Dutch801 XBd BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepPink;
            label2.Location = new Point(485, 36);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 30;
            label2.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 560);
            Controls.Add(label2);
            Controls.Add(button28);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(lstHistory);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
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
        private ListBox lstHistory;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Label label2;
    }
}
