namespace Dictionary_Tester
{
    partial class frmMain
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
            this.btnGet = new System.Windows.Forms.Button();
            this.nudKey = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(54, 65);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(70, 35);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // nudKey
            // 
            this.nudKey.Location = new System.Drawing.Point(130, 74);
            this.nudKey.Name = "nudKey";
            this.nudKey.Size = new System.Drawing.Size(44, 20);
            this.nudKey.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.nudKey);
            this.Controls.Add(this.btnGet);
            this.Name = "frmMain";
            this.Text = "Dictionary Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.NumericUpDown nudKey;
    }
}

