﻿namespace P11_714230058.view
{
    partial class ParentForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dataMahasiswaToolStripMenuItem = new ToolStripMenuItem();
            dataNilaiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dataMahasiswaToolStripMenuItem, dataNilaiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(824, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            dataMahasiswaToolStripMenuItem.Size = new Size(104, 20);
            dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            dataMahasiswaToolStripMenuItem.Click += dataMahasiswaToolStripMenuItem_Click;
            // 
            // dataNilaiToolStripMenuItem
            // 
            dataNilaiToolStripMenuItem.Name = "dataNilaiToolStripMenuItem";
            dataNilaiToolStripMenuItem.Size = new Size(70, 20);
            dataNilaiToolStripMenuItem.Text = "Data Nilai";
            dataNilaiToolStripMenuItem.Click += dataNilaiToolStripMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 641);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "ParentForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private ToolStripMenuItem dataNilaiToolStripMenuItem;
    }
}