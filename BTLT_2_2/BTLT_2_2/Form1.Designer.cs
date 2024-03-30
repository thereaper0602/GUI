namespace BTLT_2_2
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
            this.lb1 = new System.Windows.Forms.Label();
            this.ketQualb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.cTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.solveBt = new System.Windows.Forms.Button();
            this.CloseBt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình giải phương trình bậc 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(116, 183);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 31);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "a = ";
            // 
            // ketQualb
            // 
            this.ketQualb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ketQualb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ketQualb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketQualb.ForeColor = System.Drawing.Color.Red;
            this.ketQualb.Location = new System.Drawing.Point(215, 238);
            this.ketQualb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ketQualb.Name = "ketQualb";
            this.ketQualb.Size = new System.Drawing.Size(452, 72);
            this.ketQualb.TabIndex = 0;
            this.ketQualb.Text = " ";
            this.ketQualb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(109, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả";
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(379, 183);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(46, 31);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "b =";
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(641, 183);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(46, 31);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "c =";
            // 
            // aTxt
            // 
            this.aTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTxt.Location = new System.Drawing.Point(159, 180);
            this.aTxt.Margin = new System.Windows.Forms.Padding(4);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(70, 28);
            this.aTxt.TabIndex = 1;
            // 
            // cTxt
            // 
            this.cTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTxt.Location = new System.Drawing.Point(684, 179);
            this.cTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cTxt.MaxLength = 8;
            this.cTxt.Name = "cTxt";
            this.cTxt.PasswordChar = '*';
            this.cTxt.Size = new System.Drawing.Size(67, 28);
            this.cTxt.TabIndex = 1;
            // 
            // bTxt
            // 
            this.bTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTxt.Location = new System.Drawing.Point(422, 179);
            this.bTxt.Margin = new System.Windows.Forms.Padding(4);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(70, 28);
            this.bTxt.TabIndex = 1;
            // 
            // solveBt
            // 
            this.solveBt.Location = new System.Drawing.Point(130, 341);
            this.solveBt.Name = "solveBt";
            this.solveBt.Size = new System.Drawing.Size(128, 38);
            this.solveBt.TabIndex = 2;
            this.solveBt.Text = "Giải";
            this.solveBt.UseVisualStyleBackColor = true;
            this.solveBt.Click += new System.EventHandler(this.solveBt_Click);
            // 
            // CloseBt
            // 
            this.CloseBt.Location = new System.Drawing.Point(516, 341);
            this.CloseBt.Name = "CloseBt";
            this.CloseBt.Size = new System.Drawing.Size(128, 38);
            this.CloseBt.TabIndex = 2;
            this.CloseBt.Text = "Đóng";
            this.CloseBt.UseVisualStyleBackColor = true;
            this.CloseBt.Click += new System.EventHandler(this.CloseBt_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "tooltip";
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Red;
            this.timer.Location = new System.Drawing.Point(192, 111);
            this.timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(452, 42);
            this.timer.TabIndex = 3;
            this.timer.Text = " ";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 438);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.CloseBt);
            this.Controls.Add(this.solveBt);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.cTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ketQualb);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label ketQualb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox cTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.Button solveBt;
        private System.Windows.Forms.Button CloseBt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Timer timer1;
    }
}

