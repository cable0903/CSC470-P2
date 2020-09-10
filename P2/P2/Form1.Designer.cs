namespace P2
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
            this.SeeFish = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Walleye = new System.Windows.Forms.RadioButton();
            this.Perch = new System.Windows.Forms.RadioButton();
            this.Crappie = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeeFish
            // 
            this.SeeFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeFish.Location = new System.Drawing.Point(66, 241);
            this.SeeFish.Margin = new System.Windows.Forms.Padding(4);
            this.SeeFish.Name = "SeeFish";
            this.SeeFish.Size = new System.Drawing.Size(173, 62);
            this.SeeFish.TabIndex = 0;
            this.SeeFish.Text = "See Fish ";
            this.SeeFish.UseVisualStyleBackColor = true;
            this.SeeFish.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Walleye);
            this.groupBox1.Controls.Add(this.Perch);
            this.groupBox1.Controls.Add(this.Crappie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a fish to See";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Walleye
            // 
            this.Walleye.AutoSize = true;
            this.Walleye.Location = new System.Drawing.Point(49, 123);
            this.Walleye.Name = "Walleye";
            this.Walleye.Size = new System.Drawing.Size(104, 29);
            this.Walleye.TabIndex = 2;
            this.Walleye.TabStop = true;
            this.Walleye.Text = "Walleye";
            this.Walleye.UseVisualStyleBackColor = true;
            this.Walleye.CheckedChanged += new System.EventHandler(this.Walleye_CheckedChanged);
            // 
            // Perch
            // 
            this.Perch.AutoSize = true;
            this.Perch.Location = new System.Drawing.Point(49, 80);
            this.Perch.Name = "Perch";
            this.Perch.Size = new System.Drawing.Size(84, 29);
            this.Perch.TabIndex = 1;
            this.Perch.TabStop = true;
            this.Perch.Text = "Perch";
            this.Perch.UseVisualStyleBackColor = true;
            this.Perch.CheckedChanged += new System.EventHandler(this.Perch_CheckedChanged);
            // 
            // Crappie
            // 
            this.Crappie.AutoSize = true;
            this.Crappie.Location = new System.Drawing.Point(49, 41);
            this.Crappie.Name = "Crappie";
            this.Crappie.Size = new System.Drawing.Size(102, 29);
            this.Crappie.TabIndex = 0;
            this.Crappie.TabStop = true;
            this.Crappie.Text = "Crappie";
            this.Crappie.UseVisualStyleBackColor = true;
            this.Crappie.CheckedChanged += new System.EventHandler(this.Crappie_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(375, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SeeFish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CSC470-P2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeeFish;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Walleye;
        private System.Windows.Forms.RadioButton Perch;
        private System.Windows.Forms.RadioButton Crappie;
    }
}