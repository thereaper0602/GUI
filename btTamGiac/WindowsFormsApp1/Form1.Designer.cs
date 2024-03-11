namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.x1txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p3txt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBt = new System.Windows.Forms.Button();
            this.checkPolyBt = new System.Windows.Forms.Button();
            this.y1txt = new System.Windows.Forms.TextBox();
            this.y2txt = new System.Windows.Forms.TextBox();
            this.x2txt = new System.Windows.Forms.TextBox();
            this.y3txt = new System.Windows.Forms.TextBox();
            this.x3txt = new System.Windows.Forms.TextBox();
            this.c2txt = new System.Windows.Forms.TextBox();
            this.c1txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm 1";
            // 
            // x1txt
            // 
            this.x1txt.Location = new System.Drawing.Point(74, 28);
            this.x1txt.Name = "x1txt";
            this.x1txt.Size = new System.Drawing.Size(34, 22);
            this.x1txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm 2";
            // 
            // p3txt
            // 
            this.p3txt.AutoSize = true;
            this.p3txt.Location = new System.Drawing.Point(498, 44);
            this.p3txt.Name = "p3txt";
            this.p3txt.Size = new System.Drawing.Size(48, 16);
            this.p3txt.TabIndex = 0;
            this.p3txt.Text = "Điểm 3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.y3txt);
            this.groupBox1.Controls.Add(this.x3txt);
            this.groupBox1.Controls.Add(this.y2txt);
            this.groupBox1.Controls.Add(this.x2txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.p3txt);
            this.groupBox1.Controls.Add(this.y1txt);
            this.groupBox1.Controls.Add(this.x1txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(44, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.c2txt);
            this.groupBox2.Controls.Add(this.c1txt);
            this.groupBox2.Controls.Add(this.checkBt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(44, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm";
            // 
            // checkBt
            // 
            this.checkBt.Location = new System.Drawing.Point(6, 81);
            this.checkBt.Name = "checkBt";
            this.checkBt.Size = new System.Drawing.Size(162, 32);
            this.checkBt.TabIndex = 2;
            this.checkBt.Text = "Kiểm tra";
            this.checkBt.UseVisualStyleBackColor = true;
            this.checkBt.Click += new System.EventHandler(this.checkBt_Click);
            // 
            // checkPolyBt
            // 
            this.checkPolyBt.Location = new System.Drawing.Point(283, 353);
            this.checkPolyBt.Name = "checkPolyBt";
            this.checkPolyBt.Size = new System.Drawing.Size(226, 35);
            this.checkPolyBt.TabIndex = 2;
            this.checkPolyBt.Text = "Kiểm tra tam giác hợp lệ";
            this.checkPolyBt.UseVisualStyleBackColor = true;
            this.checkPolyBt.Click += new System.EventHandler(this.checkPolyBt_Click);
            // 
            // y1txt
            // 
            this.y1txt.Location = new System.Drawing.Point(74, 56);
            this.y1txt.Name = "y1txt";
            this.y1txt.Size = new System.Drawing.Size(34, 22);
            this.y1txt.TabIndex = 1;
            // 
            // y2txt
            // 
            this.y2txt.Location = new System.Drawing.Point(311, 56);
            this.y2txt.Name = "y2txt";
            this.y2txt.Size = new System.Drawing.Size(34, 22);
            this.y2txt.TabIndex = 3;
            // 
            // x2txt
            // 
            this.x2txt.Location = new System.Drawing.Point(311, 28);
            this.x2txt.Name = "x2txt";
            this.x2txt.Size = new System.Drawing.Size(34, 22);
            this.x2txt.TabIndex = 2;
            // 
            // y3txt
            // 
            this.y3txt.Location = new System.Drawing.Point(573, 56);
            this.y3txt.Name = "y3txt";
            this.y3txt.Size = new System.Drawing.Size(34, 22);
            this.y3txt.TabIndex = 5;
            // 
            // x3txt
            // 
            this.x3txt.Location = new System.Drawing.Point(573, 28);
            this.x3txt.Name = "x3txt";
            this.x3txt.Size = new System.Drawing.Size(34, 22);
            this.x3txt.TabIndex = 4;
            // 
            // c2txt
            // 
            this.c2txt.Location = new System.Drawing.Point(62, 49);
            this.c2txt.Name = "c2txt";
            this.c2txt.Size = new System.Drawing.Size(34, 22);
            this.c2txt.TabIndex = 1;
            // 
            // c1txt
            // 
            this.c1txt.Location = new System.Drawing.Point(62, 21);
            this.c1txt.Name = "c1txt";
            this.c1txt.Size = new System.Drawing.Size(34, 22);
            this.c1txt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkPolyBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x1txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p3txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button checkBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkPolyBt;
        private System.Windows.Forms.TextBox y3txt;
        private System.Windows.Forms.TextBox x3txt;
        private System.Windows.Forms.TextBox y2txt;
        private System.Windows.Forms.TextBox x2txt;
        private System.Windows.Forms.TextBox y1txt;
        private System.Windows.Forms.TextBox c2txt;
        private System.Windows.Forms.TextBox c1txt;
    }
}

