namespace weather_desktop
{
    partial class frmGlance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlance));
            this.panCurrent = new System.Windows.Forms.Panel();
            this.panToday = new System.Windows.Forms.Panel();
            this.panTomorrow = new System.Windows.Forms.Panel();
            this.panDayAfter = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panCurrent
            // 
            this.panCurrent.Location = new System.Drawing.Point(10, 10);
            this.panCurrent.Name = "panCurrent";
            this.panCurrent.Size = new System.Drawing.Size(100, 115);
            this.panCurrent.TabIndex = 0;
            // 
            // panToday
            // 
            this.panToday.Location = new System.Drawing.Point(116, 10);
            this.panToday.Name = "panToday";
            this.panToday.Size = new System.Drawing.Size(100, 150);
            this.panToday.TabIndex = 1;
            // 
            // panTomorrow
            // 
            this.panTomorrow.Location = new System.Drawing.Point(222, 10);
            this.panTomorrow.Name = "panTomorrow";
            this.panTomorrow.Size = new System.Drawing.Size(100, 150);
            this.panTomorrow.TabIndex = 2;
            // 
            // panDayAfter
            // 
            this.panDayAfter.Location = new System.Drawing.Point(332, 10);
            this.panDayAfter.Name = "panDayAfter";
            this.panDayAfter.Size = new System.Drawing.Size(100, 150);
            this.panDayAfter.TabIndex = 2;
            // 
            // frmGlance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.panDayAfter);
            this.Controls.Add(this.panTomorrow);
            this.Controls.Add(this.panToday);
            this.Controls.Add(this.panCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGlance";
            this.Text = "At A Glance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCurrent;
        private System.Windows.Forms.Panel panToday;
        private System.Windows.Forms.Panel panTomorrow;
        private System.Windows.Forms.Panel panDayAfter;
    }
}

