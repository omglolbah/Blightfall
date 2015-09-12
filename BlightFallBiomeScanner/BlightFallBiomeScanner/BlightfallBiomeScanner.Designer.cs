namespace BlightFallBiomeScanner
{
    partial class BlightfallBiomeScanner
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbChunks = new System.Windows.Forms.ProgressBar();
            this.txtWorldPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDebug.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(12, 71);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(571, 473);
            this.txtDebug.TabIndex = 1;
            this.txtDebug.Text = "Paste in the path to your save.\r\nHit \'Generate\' and wait...\r\n\r\nOutput file will b" +
    "e put in same directory as executable.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(589, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbChunks
            // 
            this.pbChunks.Location = new System.Drawing.Point(12, 42);
            this.pbChunks.Name = "pbChunks";
            this.pbChunks.Size = new System.Drawing.Size(571, 23);
            this.pbChunks.TabIndex = 3;
            // 
            // txtWorldPath
            // 
            this.txtWorldPath.Location = new System.Drawing.Point(93, 12);
            this.txtWorldPath.Name = "txtWorldPath";
            this.txtWorldPath.Size = new System.Drawing.Size(490, 20);
            this.txtWorldPath.TabIndex = 4;
            this.txtWorldPath.Text = "B:\\Games\\Technic\\modpacks\\blightfall\\saves\\ReleaseMoo";
            // 
            // BlightfallBiomeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 556);
            this.Controls.Add(this.txtWorldPath);
            this.Controls.Add(this.pbChunks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.btnGenerate);
            this.Name = "BlightfallBiomeScanner";
            this.Text = "Blightfall Biome Scanner Version 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbChunks;
        private System.Windows.Forms.TextBox txtWorldPath;
    }
}

