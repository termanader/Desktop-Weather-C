namespace DesktopWeather
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.pbCurrently = new System.Windows.Forms.PictureBox();
            this.pb3Day = new System.Windows.Forms.PictureBox();
            this.pb8Day = new System.Windows.Forms.PictureBox();
            this.rad8Day = new System.Windows.Forms.RadioButton();
            this.rad3Day = new System.Windows.Forms.RadioButton();
            this.radCurrently = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrently)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8Day)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCurrently
            // 
            this.pbCurrently.BackgroundImage = global::DesktopWeather.Properties.Resources.Currently;
            this.pbCurrently.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCurrently.ImageLocation = "";
            this.pbCurrently.Location = new System.Drawing.Point(147, 124);
            this.pbCurrently.Name = "pbCurrently";
            this.pbCurrently.Size = new System.Drawing.Size(80, 50);
            this.pbCurrently.TabIndex = 2;
            this.pbCurrently.TabStop = false;
            // 
            // pb3Day
            // 
            this.pb3Day.BackgroundImage = global::DesktopWeather.Properties.Resources.three_day;
            this.pb3Day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3Day.Location = new System.Drawing.Point(112, 68);
            this.pb3Day.Name = "pb3Day";
            this.pb3Day.Size = new System.Drawing.Size(150, 50);
            this.pb3Day.TabIndex = 1;
            this.pb3Day.TabStop = false;
            // 
            // pb8Day
            // 
            this.pb8Day.BackgroundImage = global::DesktopWeather.Properties.Resources.eight_day;
            this.pb8Day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb8Day.Location = new System.Drawing.Point(12, 12);
            this.pb8Day.Name = "pb8Day";
            this.pb8Day.Size = new System.Drawing.Size(350, 50);
            this.pb8Day.TabIndex = 0;
            this.pb8Day.TabStop = false;
            // 
            // rad8Day
            // 
            this.rad8Day.AutoSize = true;
            this.rad8Day.Location = new System.Drawing.Point(369, 29);
            this.rad8Day.Name = "rad8Day";
            this.rad8Day.Size = new System.Drawing.Size(97, 17);
            this.rad8Day.TabIndex = 3;
            this.rad8Day.Text = "8-Day Forecast";
            this.rad8Day.UseVisualStyleBackColor = true;
            this.rad8Day.CheckedChanged += new System.EventHandler(this.rad8Day_CheckedChanged);
            // 
            // rad3Day
            // 
            this.rad3Day.AutoSize = true;
            this.rad3Day.Checked = true;
            this.rad3Day.Location = new System.Drawing.Point(369, 85);
            this.rad3Day.Name = "rad3Day";
            this.rad3Day.Size = new System.Drawing.Size(97, 17);
            this.rad3Day.TabIndex = 4;
            this.rad3Day.TabStop = true;
            this.rad3Day.Text = "3-Day Forecast";
            this.rad3Day.UseVisualStyleBackColor = true;
            this.rad3Day.CheckedChanged += new System.EventHandler(this.rad3Day_CheckedChanged);
            // 
            // radCurrently
            // 
            this.radCurrently.AutoSize = true;
            this.radCurrently.Location = new System.Drawing.Point(369, 141);
            this.radCurrently.Name = "radCurrently";
            this.radCurrently.Size = new System.Drawing.Size(111, 17);
            this.radCurrently.TabIndex = 5;
            this.radCurrently.Text = "Current Conditions";
            this.radCurrently.UseVisualStyleBackColor = true;
            this.radCurrently.CheckedChanged += new System.EventHandler(this.radCurrently_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radCurrently);
            this.Controls.Add(this.rad3Day);
            this.Controls.Add(this.rad8Day);
            this.Controls.Add(this.pbCurrently);
            this.Controls.Add(this.pb3Day);
            this.Controls.Add(this.pb8Day);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Desktop Weather Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrently)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8Day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb8Day;
        private System.Windows.Forms.PictureBox pb3Day;
        private System.Windows.Forms.PictureBox pbCurrently;
        private System.Windows.Forms.RadioButton rad8Day;
        private System.Windows.Forms.RadioButton rad3Day;
        private System.Windows.Forms.RadioButton radCurrently;
        private System.Windows.Forms.Button btnSave;
    }
}