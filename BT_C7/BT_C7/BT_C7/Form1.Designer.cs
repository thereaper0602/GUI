﻿namespace BT_C7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawByMouseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drawTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drawImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawByMouseToolStripMenuItem1,
            this.drawTextToolStripMenuItem1,
            this.drawImageToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // drawByMouseToolStripMenuItem1
            // 
            this.drawByMouseToolStripMenuItem1.Name = "drawByMouseToolStripMenuItem1";
            this.drawByMouseToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.drawByMouseToolStripMenuItem1.Text = "Draw By Mouse";
            this.drawByMouseToolStripMenuItem1.Click += new System.EventHandler(this.drawByMouseToolStripMenuItem1_Click);
            // 
            // drawTextToolStripMenuItem1
            // 
            this.drawTextToolStripMenuItem1.Name = "drawTextToolStripMenuItem1";
            this.drawTextToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.drawTextToolStripMenuItem1.Text = "Draw Text";
            this.drawTextToolStripMenuItem1.Click += new System.EventHandler(this.drawTextToolStripMenuItem1_Click);
            // 
            // drawImageToolStripMenuItem1
            // 
            this.drawImageToolStripMenuItem1.Name = "drawImageToolStripMenuItem1";
            this.drawImageToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.drawImageToolStripMenuItem1.Text = "Draw Image";
            this.drawImageToolStripMenuItem1.Click += new System.EventHandler(this.drawImageToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 712);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawByMouseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem drawTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem drawImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

