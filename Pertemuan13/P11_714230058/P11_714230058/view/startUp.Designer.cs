namespace P11_714230058.view
{
    partial class startUp
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(308, 29);
            label1.TabIndex = 0;
            label1.Text = "PROJECT APPLICATION";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(44, 403);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(616, 23);
            progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(25, 311);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(634, 38);
            progressBar2.TabIndex = 2;
            progressBar2.Click += progressBar2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(25, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(634, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // startUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "startUp";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}