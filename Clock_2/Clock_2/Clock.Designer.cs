namespace Clock_2
{
    partial class Clock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockLb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clockLb
            // 
            this.clockLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clockLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockLb.Location = new System.Drawing.Point(2, 2);
            this.clockLb.Name = "clockLb";
            this.clockLb.Size = new System.Drawing.Size(324, 148);
            this.clockLb.TabIndex = 0;
            this.clockLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clockLb);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(329, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clockLb;
        private System.Windows.Forms.Timer timer1;
    }
}
