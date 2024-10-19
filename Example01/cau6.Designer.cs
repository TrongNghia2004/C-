namespace Example01
{
    partial class cau6
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btKetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(126, 38);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(395, 27);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(69, 101);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(71, 53);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(206, 101);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(72, 53);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(342, 101);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(76, 53);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(481, 101);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 53);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(69, 217);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(71, 53);
            this.btMul.TabIndex = 5;
            this.btMul.Text = "+";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(206, 217);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(72, 53);
            this.btEquals.TabIndex = 6;
            this.btEquals.Text = "*";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(342, 217);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(76, 53);
            this.btPlus.TabIndex = 7;
            this.btPlus.Text = ".";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btKetQua
            // 
            this.btKetQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btKetQua.Location = new System.Drawing.Point(481, 217);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Size = new System.Drawing.Size(75, 53);
            this.btKetQua.TabIndex = 8;
            this.btKetQua.Text = "=";
            this.btKetQua.UseVisualStyleBackColor = true;
            this.btKetQua.Click += new System.EventHandler(this.btKetQua_Click);

            // 
            // cau6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btKetQua);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDisplay);
            this.Name = "cau6";
            this.Text = "cau6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btMul;
        private Button btEquals;
        private Button btPlus;
        private Button btKetQua;
    }
}