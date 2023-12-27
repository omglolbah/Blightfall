namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.pG = new System.Windows.Forms.Panel();
            this.pB = new System.Windows.Forms.PictureBox();
            this.btnImageLayout = new System.Windows.Forms.Button();
            this.pG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(12, 12);
            this.btnSnapshot.Name = "button1";
            this.btnSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnSnapshot.TabIndex = 0;
            this.btnSnapshot.Text = "Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(12, 41);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(419, 397);
            this.txtDebug.TabIndex = 1;
            // 
            // pG
            // 
            this.pG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pG.AutoScroll = true;
            this.pG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pG.Controls.Add(this.pB);
            this.pG.Location = new System.Drawing.Point(437, 12);
            this.pG.Name = "pG";
            this.pG.Size = new System.Drawing.Size(351, 426);
            this.pG.TabIndex = 2;
            // 
            // pB
            // 
            this.pB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB.Location = new System.Drawing.Point(3, 3);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(343, 418);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB.TabIndex = 4;
            this.pB.TabStop = false;
            // 
            // btnImageLayout
            // 
            this.btnImageLayout.Location = new System.Drawing.Point(356, 12);
            this.btnImageLayout.Name = "button2";
            this.btnImageLayout.Size = new System.Drawing.Size(75, 23);
            this.btnImageLayout.TabIndex = 3;
            this.btnImageLayout.Text = "Zoom/Full";
            this.btnImageLayout.UseVisualStyleBackColor = true;
            this.btnImageLayout.Click += new System.EventHandler(this.btnImageLayout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImageLayout);
            this.Controls.Add(this.pG);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.btnSnapshot);
            this.Name = "MainForm";
            this.Text = "Blightfall Mapper";
            this.pG.ResumeLayout(false);
            this.pG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSnapshot;
        private TextBox txtDebug;
        private Panel pG;
        private Button btnImageLayout;
        private PictureBox pB;
    }
}