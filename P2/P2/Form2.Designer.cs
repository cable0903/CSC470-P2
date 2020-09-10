namespace P2
{
    partial class Form2
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
            this.keep = new System.Windows.Forms.Button();
            this.thorw = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // keep
            // 
            this.keep.Location = new System.Drawing.Point(802, 435);
            this.keep.Name = "keep";
            this.keep.Size = new System.Drawing.Size(174, 68);
            this.keep.TabIndex = 0;
            this.keep.Text = "Keep It ";
            this.keep.UseVisualStyleBackColor = true;
            this.keep.Click += new System.EventHandler(this.keep_Click);
            // 
            // thorw
            // 
            this.thorw.Location = new System.Drawing.Point(464, 435);
            this.thorw.Name = "thorw";
            this.thorw.Size = new System.Drawing.Size(167, 68);
            this.thorw.TabIndex = 1;
            this.thorw.Text = "Throw It ";
            this.thorw.UseVisualStyleBackColor = true;
            this.thorw.Click += new System.EventHandler(this.thorw_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(138, 435);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(165, 67);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.calcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(138, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.thorw);
            this.Controls.Add(this.keep);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Keep it or Let it go ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button keep;
        private System.Windows.Forms.Button thorw;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}