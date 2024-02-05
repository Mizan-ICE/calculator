namespace calculator
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
            textBox1 = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            plus = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            minus = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            multi = new Button();
            n0 = new Button();
            equal = new Button();
            clear = new Button();
            div = new Button();
            point = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(22, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 37);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // n1
            // 
            n1.Location = new Point(22, 44);
            n1.Name = "n1";
            n1.Size = new Size(37, 23);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.Location = new Point(65, 44);
            n2.Name = "n2";
            n2.Size = new Size(37, 23);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.Location = new Point(108, 44);
            n3.Name = "n3";
            n3.Size = new Size(37, 23);
            n3.TabIndex = 3;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            // 
            // plus
            // 
            plus.Location = new Point(151, 44);
            plus.Name = "plus";
            plus.Size = new Size(37, 23);
            plus.TabIndex = 4;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // n4
            // 
            n4.Location = new Point(22, 73);
            n4.Name = "n4";
            n4.Size = new Size(37, 23);
            n4.TabIndex = 5;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.Location = new Point(65, 73);
            n5.Name = "n5";
            n5.Size = new Size(37, 23);
            n5.TabIndex = 6;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.Location = new Point(108, 73);
            n6.Name = "n6";
            n6.Size = new Size(37, 23);
            n6.TabIndex = 7;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n6_Click;
            // 
            // minus
            // 
            minus.Location = new Point(151, 73);
            minus.Name = "minus";
            minus.Size = new Size(37, 23);
            minus.TabIndex = 8;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // n7
            // 
            n7.Location = new Point(22, 102);
            n7.Name = "n7";
            n7.Size = new Size(37, 23);
            n7.TabIndex = 9;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.Location = new Point(65, 102);
            n8.Name = "n8";
            n8.Size = new Size(37, 23);
            n8.TabIndex = 10;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.Location = new Point(108, 102);
            n9.Name = "n9";
            n9.Size = new Size(37, 23);
            n9.TabIndex = 11;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n9_Click;
            // 
            // multi
            // 
            multi.Location = new Point(151, 102);
            multi.Name = "multi";
            multi.Size = new Size(37, 23);
            multi.TabIndex = 12;
            multi.Text = "x";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // n0
            // 
            n0.Location = new Point(65, 131);
            n0.Name = "n0";
            n0.Size = new Size(37, 23);
            n0.TabIndex = 13;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n0_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.Highlight;
            equal.ForeColor = SystemColors.ControlText;
            equal.Location = new Point(22, 160);
            equal.Name = "equal";
            equal.Size = new Size(166, 23);
            equal.TabIndex = 14;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Red;
            clear.Location = new Point(22, 131);
            clear.Name = "clear";
            clear.Size = new Size(37, 23);
            clear.TabIndex = 15;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // div
            // 
            div.Location = new Point(151, 131);
            div.Name = "div";
            div.Size = new Size(37, 23);
            div.TabIndex = 16;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // point
            // 
            point.Location = new Point(108, 131);
            point.Name = "point";
            point.Size = new Size(37, 23);
            point.TabIndex = 17;
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            point.Click += point_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 244);
            Controls.Add(point);
            Controls.Add(div);
            Controls.Add(clear);
            Controls.Add(equal);
            Controls.Add(n0);
            Controls.Add(multi);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(minus);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(plus);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button plus;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button minus;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button multi;
        private Button n0;
        private Button equal;
        private Button clear;
        private Button div;
        private Button point;
    }
}
