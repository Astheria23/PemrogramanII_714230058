namespace P5_2_714230058
{
    partial class ChildForm
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DataOption = new System.Windows.Forms.RadioButton();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 16);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(292, 32);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(46, 88);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 25);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(171, 88);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DataOption);
            this.OutputGroupBox.Location = new System.Drawing.Point(46, 152);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(200, 104);
            this.OutputGroupBox.TabIndex = 3;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Choose Output";
            // 
            // TimeOption
            // 
            this.TimeOption.Location = new System.Drawing.Point(19, 68);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 3;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current &Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.CheckedChanged += new System.EventHandler(this.TimeOption_CheckedChanged);
            // 
            // DataOption
            // 
            this.DataOption.Location = new System.Drawing.Point(19, 31);
            this.DataOption.Name = "DataOption";
            this.DataOption.Size = new System.Drawing.Size(168, 24);
            this.DataOption.TabIndex = 3;
            this.DataOption.TabStop = true;
            this.DataOption.Text = "Display Current D&ate";
            this.DataOption.UseVisualStyleBackColor = true;
            this.DataOption.CheckedChanged += new System.EventHandler(this.DataOption_CheckedChanged);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(293, 280);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.OutputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DataOption;
    }
}