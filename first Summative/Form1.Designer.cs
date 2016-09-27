namespace first_Summative
{
    partial class TAURUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAURUS));
            this.startbutton1 = new System.Windows.Forms.Button();
            this.taurusTitleLabel = new System.Windows.Forms.Label();
            this.descripitionLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton1
            // 
            this.startbutton1.Location = new System.Drawing.Point(321, 392);
            this.startbutton1.Name = "startbutton1";
            this.startbutton1.Size = new System.Drawing.Size(75, 23);
            this.startbutton1.TabIndex = 0;
            this.startbutton1.Text = "Start";
            this.startbutton1.UseVisualStyleBackColor = true;
            this.startbutton1.UseWaitCursor = true;
            this.startbutton1.Click += new System.EventHandler(this.startbutton1_Click);
            // 
            // taurusTitleLabel
            // 
            this.taurusTitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taurusTitleLabel.Font = new System.Drawing.Font("Trajan Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taurusTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taurusTitleLabel.Location = new System.Drawing.Point(189, 216);
            this.taurusTitleLabel.Name = "taurusTitleLabel";
            this.taurusTitleLabel.Size = new System.Drawing.Size(369, 58);
            this.taurusTitleLabel.TabIndex = 1;
            this.taurusTitleLabel.Text = "THE TAURUS";
            this.taurusTitleLabel.UseWaitCursor = true;
            // 
            // descripitionLabel1
            // 
            this.descripitionLabel1.AutoSize = true;
            this.descripitionLabel1.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripitionLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.descripitionLabel1.Location = new System.Drawing.Point(35, 287);
            this.descripitionLabel1.Name = "descripitionLabel1";
            this.descripitionLabel1.Size = new System.Drawing.Size(0, 18);
            this.descripitionLabel1.TabIndex = 2;
            // 
            // TAURUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 536);
            this.Controls.Add(this.descripitionLabel1);
            this.Controls.Add(this.taurusTitleLabel);
            this.Controls.Add(this.startbutton1);
            this.Name = "TAURUS";
            this.Text = "TAURUS";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton1;
        protected internal System.Windows.Forms.Label taurusTitleLabel;
        private System.Windows.Forms.Label descripitionLabel1;
    }
}

