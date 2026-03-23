
namespace Ednevnik410b
{
    partial class Glavna
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMerrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskagodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sifarniciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Forma";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem2.Text = "Osobe";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem3.Text = "Upisnica";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // sifarniciToolStripMenuItem
            // 
            this.sifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odeljenjeToolStripMenuItem,
            this.sMerrToolStripMenuItem,
            this.ocenaToolStripMenuItem,
            this.predmetToolStripMenuItem,
            this.raspodelaToolStripMenuItem,
            this.skolskagodinaToolStripMenuItem});
            this.sifarniciToolStripMenuItem.Name = "sifarniciToolStripMenuItem";
            this.sifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sifarniciToolStripMenuItem.Text = "Sifarnici";
            // 
            // odeljenjeToolStripMenuItem
            // 
            this.odeljenjeToolStripMenuItem.Name = "odeljenjeToolStripMenuItem";
            this.odeljenjeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.odeljenjeToolStripMenuItem.Text = "Odeljenje";
            this.odeljenjeToolStripMenuItem.Click += new System.EventHandler(this.odeljenjeToolStripMenuItem_Click);
            // 
            // sMerrToolStripMenuItem
            // 
            this.sMerrToolStripMenuItem.Name = "sMerrToolStripMenuItem";
            this.sMerrToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sMerrToolStripMenuItem.Text = "Smer";
            this.sMerrToolStripMenuItem.Click += new System.EventHandler(this.sMerrToolStripMenuItem_Click);
            // 
            // ocenaToolStripMenuItem
            // 
            this.ocenaToolStripMenuItem.Name = "ocenaToolStripMenuItem";
            this.ocenaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ocenaToolStripMenuItem.Text = "Ocena";
            this.ocenaToolStripMenuItem.Click += new System.EventHandler(this.ocenaToolStripMenuItem_Click);
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.predmetToolStripMenuItem.Text = "Predmet";
            this.predmetToolStripMenuItem.Click += new System.EventHandler(this.predmetToolStripMenuItem_Click);
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // skolskagodinaToolStripMenuItem
            // 
            this.skolskagodinaToolStripMenuItem.Name = "skolskagodinaToolStripMenuItem";
            this.skolskagodinaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.skolskagodinaToolStripMenuItem.Text = "Skolska_godina";
            this.skolskagodinaToolStripMenuItem.Click += new System.EventHandler(this.skolskagodinaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 122);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odeljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMerrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskagodinaToolStripMenuItem;
    }
}