namespace dbdb
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
            plus = new Button();
            t1 = new TextBox();
            t2 = new TextBox();
            result = new TextBox();
            minus = new Button();
            multi = new Button();
            division = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // plus
            // 
            plus.Location = new Point(453, 184);
            plus.Name = "plus";
            plus.Size = new Size(75, 23);
            plus.TabIndex = 1;
            plus.Text = "덧셈 ( + )";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // t1
            // 
            t1.Location = new Point(327, 184);
            t1.Name = "t1";
            t1.Size = new Size(100, 23);
            t1.TabIndex = 2;
            // 
            // t2
            // 
            t2.Location = new Point(327, 225);
            t2.Name = "t2";
            t2.Size = new Size(100, 23);
            t2.TabIndex = 6;
            // 
            // result
            // 
            result.Location = new Point(327, 269);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 7;
            // 
            // minus
            // 
            minus.Location = new Point(453, 225);
            minus.Name = "minus";
            minus.Size = new Size(75, 23);
            minus.TabIndex = 8;
            minus.Text = "뺼셈 ( - )";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multi
            // 
            multi.Location = new Point(453, 269);
            multi.Name = "multi";
            multi.Size = new Size(75, 23);
            multi.TabIndex = 9;
            multi.Text = "곱셈 ( x )";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // division
            // 
            division.Location = new Point(453, 310);
            division.Name = "division";
            division.Size = new Size(90, 23);
            division.TabIndex = 10;
            division.Text = "나눗셈 ( / )";
            division.UseVisualStyleBackColor = true;
            division.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F);
            label1.Location = new Point(273, 111);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 11;
            label1.Text = "간단한 계산기 프로그램";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 192);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 12;
            label2.Text = "첫 번쨰 수:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 233);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 13;
            label3.Text = "두 번째 수:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 277);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 14;
            label4.Text = "계산 결과:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 314);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point(255, 310);
            button5.Name = "button5";
            button5.Size = new Size(172, 23);
            button5.TabIndex = 16;
            button5.Text = "오늘은 무슨 요일일까요?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(division);
            Controls.Add(multi);
            Controls.Add(minus);
            Controls.Add(result);
            Controls.Add(t2);
            Controls.Add(t1);
            Controls.Add(plus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button plus;
        private TextBox t1;
        private TextBox t2;
        private TextBox result;
        private Button minus;
        private Button multi;
        private Button division;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
    }
}
