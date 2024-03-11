namespace BT_2_5
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.s1Txt = new System.Windows.Forms.TextBox();
            this.s2Txt = new System.Windows.Forms.TextBox();
            this.s3Txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chenBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chenTxt = new System.Windows.Forms.TextBox();
            this.replace_s2_s3Bt = new System.Windows.Forms.Button();
            this.delS2 = new System.Windows.Forms.Button();
            this.reverseBt = new System.Windows.Forms.Button();
            this.normalizedBt = new System.Windows.Forms.Button();
            this.refreshBt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getSubStringBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idxNumTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình xử lý chuỗi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi s1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuỗi s2";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chuỗi s3";
            // 
            // s1Txt
            // 
            this.s1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1Txt.Location = new System.Drawing.Point(126, 100);
            this.s1Txt.Name = "s1Txt";
            this.s1Txt.Size = new System.Drawing.Size(746, 30);
            this.s1Txt.TabIndex = 2;
            // 
            // s2Txt
            // 
            this.s2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2Txt.Location = new System.Drawing.Point(126, 146);
            this.s2Txt.Name = "s2Txt";
            this.s2Txt.Size = new System.Drawing.Size(312, 30);
            this.s2Txt.TabIndex = 2;
            // 
            // s3Txt
            // 
            this.s3Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s3Txt.Location = new System.Drawing.Point(556, 147);
            this.s3Txt.Name = "s3Txt";
            this.s3Txt.Size = new System.Drawing.Size(314, 30);
            this.s3Txt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chenBt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chenTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn chuỗi s2 vào s1";
            // 
            // chenBt
            // 
            this.chenBt.Location = new System.Drawing.Point(272, 32);
            this.chenBt.Name = "chenBt";
            this.chenBt.Size = new System.Drawing.Size(86, 28);
            this.chenBt.TabIndex = 3;
            this.chenBt.Text = "chèn";
            this.chenBt.UseVisualStyleBackColor = true;
            this.chenBt.Click += new System.EventHandler(this.chenBt_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vị trí chèn";
            // 
            // chenTxt
            // 
            this.chenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chenTxt.Location = new System.Drawing.Point(109, 32);
            this.chenTxt.Name = "chenTxt";
            this.chenTxt.Size = new System.Drawing.Size(86, 30);
            this.chenTxt.TabIndex = 2;
            // 
            // replace_s2_s3Bt
            // 
            this.replace_s2_s3Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replace_s2_s3Bt.Location = new System.Drawing.Point(461, 218);
            this.replace_s2_s3Bt.Name = "replace_s2_s3Bt";
            this.replace_s2_s3Bt.Size = new System.Drawing.Size(196, 50);
            this.replace_s2_s3Bt.TabIndex = 3;
            this.replace_s2_s3Bt.Text = "Thay s2 bằng s3";
            this.replace_s2_s3Bt.UseVisualStyleBackColor = true;
            this.replace_s2_s3Bt.Click += new System.EventHandler(this.replace_s2_s3Bt_Click);
            // 
            // delS2
            // 
            this.delS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delS2.Location = new System.Drawing.Point(461, 274);
            this.delS2.Name = "delS2";
            this.delS2.Size = new System.Drawing.Size(196, 50);
            this.delS2.TabIndex = 3;
            this.delS2.Text = "Xóa s2 trong s1";
            this.delS2.UseVisualStyleBackColor = true;
            this.delS2.Click += new System.EventHandler(this.delS2_Click);
            // 
            // reverseBt
            // 
            this.reverseBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseBt.Location = new System.Drawing.Point(664, 218);
            this.reverseBt.Name = "reverseBt";
            this.reverseBt.Size = new System.Drawing.Size(191, 50);
            this.reverseBt.TabIndex = 3;
            this.reverseBt.Text = "Đảo từ trong s1";
            this.reverseBt.UseVisualStyleBackColor = true;
            this.reverseBt.Click += new System.EventHandler(this.reverseBt_Click);
            // 
            // normalizedBt
            // 
            this.normalizedBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalizedBt.Location = new System.Drawing.Point(664, 274);
            this.normalizedBt.Name = "normalizedBt";
            this.normalizedBt.Size = new System.Drawing.Size(191, 50);
            this.normalizedBt.TabIndex = 3;
            this.normalizedBt.Text = "Chuẩn hóa chuỗi";
            this.normalizedBt.UseVisualStyleBackColor = true;
            this.normalizedBt.Click += new System.EventHandler(this.normalizedBt_Click);
            // 
            // refreshBt
            // 
            this.refreshBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBt.Location = new System.Drawing.Point(706, 375);
            this.refreshBt.Name = "refreshBt";
            this.refreshBt.Size = new System.Drawing.Size(117, 28);
            this.refreshBt.TabIndex = 3;
            this.refreshBt.Text = "Khôi phục";
            this.refreshBt.UseVisualStyleBackColor = true;
            this.refreshBt.Click += new System.EventHandler(this.refreshBt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getSubStringBt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.idxNumTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fromTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // getSubStringBt
            // 
            this.getSubStringBt.Location = new System.Drawing.Point(425, 34);
            this.getSubStringBt.Name = "getSubStringBt";
            this.getSubStringBt.Size = new System.Drawing.Size(127, 30);
            this.getSubStringBt.TabIndex = 3;
            this.getSubStringBt.Text = "Lấy chuỗi con";
            this.getSubStringBt.UseVisualStyleBackColor = true;
            this.getSubStringBt.Click += new System.EventHandler(this.getSubStringBt_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số ký tự";
            // 
            // idxNumTxt
            // 
            this.idxNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idxNumTxt.Location = new System.Drawing.Point(316, 32);
            this.idxNumTxt.Name = "idxNumTxt";
            this.idxNumTxt.Size = new System.Drawing.Size(86, 30);
            this.idxNumTxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Từ vị trí:";
            // 
            // fromTxt
            // 
            this.fromTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTxt.Location = new System.Drawing.Point(108, 32);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(86, 30);
            this.fromTxt.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.normalizedBt);
            this.Controls.Add(this.reverseBt);
            this.Controls.Add(this.refreshBt);
            this.Controls.Add(this.delS2);
            this.Controls.Add(this.replace_s2_s3Bt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.s3Txt);
            this.Controls.Add(this.s2Txt);
            this.Controls.Add(this.s1Txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Xử lý chuỗi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox s1Txt;
        private System.Windows.Forms.TextBox s2Txt;
        private System.Windows.Forms.TextBox s3Txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chenBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chenTxt;
        private System.Windows.Forms.Button replace_s2_s3Bt;
        private System.Windows.Forms.Button delS2;
        private System.Windows.Forms.Button reverseBt;
        private System.Windows.Forms.Button normalizedBt;
        private System.Windows.Forms.Button refreshBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getSubStringBt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idxNumTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.Timer timer1;
    }
}

