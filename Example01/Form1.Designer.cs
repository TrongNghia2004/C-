namespace Example01
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cau7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(124, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thông tin sinh viên chi tiết";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(351, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thông Tin Sinh Viên";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(561, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thông Tin Khoa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(561, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Máy Tính Nâng Cao";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Location = new System.Drawing.Point(351, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "Máy Tính";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Location = new System.Drawing.Point(124, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 56);
            this.button6.TabIndex = 5;
            this.button6.Text = "Máy Tính Cơ Bản";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cau7
            // 
            this.cau7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cau7.Location = new System.Drawing.Point(745, 119);
            this.cau7.Name = "cau7";
            this.cau7.Size = new System.Drawing.Size(94, 63);
            this.cau7.TabIndex = 6;
            this.cau7.Text = "Quản Lý Sinh Viên";
            this.cau7.UseVisualStyleBackColor = false;
            this.cau7.Click += new System.EventHandler(this.cau7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.cau7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button cau7;
    }
}