namespace DesktopWeather
{
    partial class frmCurrently
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrently));
            this.lblCurrentConditions = new System.Windows.Forms.Label();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.panCurrent = new System.Windows.Forms.Panel();
            this.pbCurrentConditions = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentConditions
            // 
            this.lblCurrentConditions.AutoSize = true;
            this.lblCurrentConditions.Location = new System.Drawing.Point(3, 93);
            this.lblCurrentConditions.MaximumSize = new System.Drawing.Size(95, 20);
            this.lblCurrentConditions.Name = "lblCurrentConditions";
            this.lblCurrentConditions.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentConditions.TabIndex = 9;
            this.lblCurrentConditions.Text = "label1";
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.AutoSize = true;
            this.lblCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTemp.Location = new System.Drawing.Point(3, 29);
            this.lblCurrentTemp.MaximumSize = new System.Drawing.Size(95, 0);
            this.lblCurrentTemp.MinimumSize = new System.Drawing.Size(95, 0);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(95, 22);
            this.lblCurrentTemp.TabIndex = 7;
            this.lblCurrentTemp.Text = "000";
            this.lblCurrentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(4, 4);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(93, 13);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Conditions";
            // 
            // panCurrent
            // 
            this.panCurrent.Controls.Add(this.lblCurrentConditions);
            this.panCurrent.Controls.Add(this.pbCurrentConditions);
            this.panCurrent.Controls.Add(this.lblCurrentTemp);
            this.panCurrent.Controls.Add(this.lblCurrent);
            this.panCurrent.Location = new System.Drawing.Point(12, 12);
            this.panCurrent.Name = "panCurrent";
            this.panCurrent.Size = new System.Drawing.Size(100, 115);
            this.panCurrent.TabIndex = 1;
            // 
            // pbCurrentConditions
            // 
            this.pbCurrentConditions.Location = new System.Drawing.Point(28, 60);
            this.pbCurrentConditions.Name = "pbCurrentConditions";
            this.pbCurrentConditions.Size = new System.Drawing.Size(45, 30);
            this.pbCurrentConditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentConditions.TabIndex = 8;
            this.pbCurrentConditions.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 133);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(53, 23);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(87, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmCurrently
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 171);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panCurrent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurrently";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Currently";
            this.TopMost = true;
            this.panCurrent.ResumeLayout(false);
            this.panCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentConditions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentConditions;
        private System.Windows.Forms.PictureBox pbCurrentConditions;
        private System.Windows.Forms.Label lblCurrentTemp;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Panel panCurrent;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRefresh;
    }
}