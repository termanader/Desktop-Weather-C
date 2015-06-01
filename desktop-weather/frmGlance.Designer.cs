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
            this.lblCurrentConditions = new System.Windows.Forms.Label();
            this.pbCurrentConditions = new System.Windows.Forms.PictureBox();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.panToday = new System.Windows.Forms.Panel();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblTodayConditions = new System.Windows.Forms.Label();
            this.pbTodayConditions = new System.Windows.Forms.PictureBox();
            this.lblTodayTemp = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.panTomorrow = new System.Windows.Forms.Panel();
            this.lblTomorrowDate = new System.Windows.Forms.Label();
            this.lblTomorrowConditions = new System.Windows.Forms.Label();
            this.pbTomorrowConditions = new System.Windows.Forms.PictureBox();
            this.lblTomorrowTemp = new System.Windows.Forms.Label();
            this.lblTomorrow = new System.Windows.Forms.Label();
            this.panDayAfter = new System.Windows.Forms.Panel();
            this.lblDayAfterDate = new System.Windows.Forms.Label();
            this.lblDayAfterConditions = new System.Windows.Forms.Label();
            this.pbDayAfterConditions = new System.Windows.Forms.PictureBox();
            this.lblDayAfterTemp = new System.Windows.Forms.Label();
            this.lblDayAfter = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentConditions)).BeginInit();
            this.panToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayConditions)).BeginInit();
            this.panTomorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrowConditions)).BeginInit();
            this.panDayAfter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panCurrent
            // 
            this.panCurrent.Controls.Add(this.lblCurrentConditions);
            this.panCurrent.Controls.Add(this.pbCurrentConditions);
            this.panCurrent.Controls.Add(this.lblCurrentTemp);
            this.panCurrent.Controls.Add(this.lblCurrent);
            this.panCurrent.Location = new System.Drawing.Point(10, 10);
            this.panCurrent.Name = "panCurrent";
            this.panCurrent.Size = new System.Drawing.Size(100, 115);
            this.panCurrent.TabIndex = 0;
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
            // pbCurrentConditions
            // 
            this.pbCurrentConditions.Location = new System.Drawing.Point(28, 60);
            this.pbCurrentConditions.Name = "pbCurrentConditions";
            this.pbCurrentConditions.Size = new System.Drawing.Size(45, 30);
            this.pbCurrentConditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentConditions.TabIndex = 8;
            this.pbCurrentConditions.TabStop = false;
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
            // panToday
            // 
            this.panToday.Controls.Add(this.lblTodayDate);
            this.panToday.Controls.Add(this.lblTodayConditions);
            this.panToday.Controls.Add(this.pbTodayConditions);
            this.panToday.Controls.Add(this.lblTodayTemp);
            this.panToday.Controls.Add(this.lblToday);
            this.panToday.Location = new System.Drawing.Point(116, 10);
            this.panToday.Name = "panToday";
            this.panToday.Size = new System.Drawing.Size(100, 150);
            this.panToday.TabIndex = 1;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(31, 133);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(42, 17);
            this.lblTodayDate.TabIndex = 11;
            this.lblTodayDate.Text = "Date";
            // 
            // lblTodayConditions
            // 
            this.lblTodayConditions.AutoSize = true;
            this.lblTodayConditions.Location = new System.Drawing.Point(3, 93);
            this.lblTodayConditions.MaximumSize = new System.Drawing.Size(95, 40);
            this.lblTodayConditions.Name = "lblTodayConditions";
            this.lblTodayConditions.Size = new System.Drawing.Size(35, 13);
            this.lblTodayConditions.TabIndex = 10;
            this.lblTodayConditions.Text = "label1";
            // 
            // pbTodayConditions
            // 
            this.pbTodayConditions.Location = new System.Drawing.Point(28, 60);
            this.pbTodayConditions.Name = "pbTodayConditions";
            this.pbTodayConditions.Size = new System.Drawing.Size(45, 30);
            this.pbTodayConditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTodayConditions.TabIndex = 9;
            this.pbTodayConditions.TabStop = false;
            // 
            // lblTodayTemp
            // 
            this.lblTodayTemp.AutoSize = true;
            this.lblTodayTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTemp.Location = new System.Drawing.Point(3, 29);
            this.lblTodayTemp.MaximumSize = new System.Drawing.Size(95, 0);
            this.lblTodayTemp.MinimumSize = new System.Drawing.Size(95, 0);
            this.lblTodayTemp.Name = "lblTodayTemp";
            this.lblTodayTemp.Size = new System.Drawing.Size(95, 22);
            this.lblTodayTemp.TabIndex = 8;
            this.lblTodayTemp.Text = "000";
            this.lblTodayTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(6, 4);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(88, 13);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Today\'s Forecast";
            // 
            // panTomorrow
            // 
            this.panTomorrow.Controls.Add(this.lblTomorrowDate);
            this.panTomorrow.Controls.Add(this.lblTomorrowConditions);
            this.panTomorrow.Controls.Add(this.pbTomorrowConditions);
            this.panTomorrow.Controls.Add(this.lblTomorrowTemp);
            this.panTomorrow.Controls.Add(this.lblTomorrow);
            this.panTomorrow.Location = new System.Drawing.Point(222, 10);
            this.panTomorrow.Name = "panTomorrow";
            this.panTomorrow.Size = new System.Drawing.Size(100, 150);
            this.panTomorrow.TabIndex = 2;
            // 
            // lblTomorrowDate
            // 
            this.lblTomorrowDate.AutoSize = true;
            this.lblTomorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowDate.Location = new System.Drawing.Point(31, 133);
            this.lblTomorrowDate.Name = "lblTomorrowDate";
            this.lblTomorrowDate.Size = new System.Drawing.Size(42, 17);
            this.lblTomorrowDate.TabIndex = 12;
            this.lblTomorrowDate.Text = "Date";
            // 
            // lblTomorrowConditions
            // 
            this.lblTomorrowConditions.AutoSize = true;
            this.lblTomorrowConditions.Location = new System.Drawing.Point(3, 93);
            this.lblTomorrowConditions.MaximumSize = new System.Drawing.Size(95, 40);
            this.lblTomorrowConditions.Name = "lblTomorrowConditions";
            this.lblTomorrowConditions.Size = new System.Drawing.Size(35, 13);
            this.lblTomorrowConditions.TabIndex = 11;
            this.lblTomorrowConditions.Text = "label1";
            // 
            // pbTomorrowConditions
            // 
            this.pbTomorrowConditions.Location = new System.Drawing.Point(28, 60);
            this.pbTomorrowConditions.Name = "pbTomorrowConditions";
            this.pbTomorrowConditions.Size = new System.Drawing.Size(45, 30);
            this.pbTomorrowConditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTomorrowConditions.TabIndex = 10;
            this.pbTomorrowConditions.TabStop = false;
            // 
            // lblTomorrowTemp
            // 
            this.lblTomorrowTemp.AutoSize = true;
            this.lblTomorrowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowTemp.Location = new System.Drawing.Point(3, 29);
            this.lblTomorrowTemp.MaximumSize = new System.Drawing.Size(95, 0);
            this.lblTomorrowTemp.MinimumSize = new System.Drawing.Size(95, 0);
            this.lblTomorrowTemp.Name = "lblTomorrowTemp";
            this.lblTomorrowTemp.Size = new System.Drawing.Size(95, 22);
            this.lblTomorrowTemp.TabIndex = 9;
            this.lblTomorrowTemp.Text = "000";
            this.lblTomorrowTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTomorrow
            // 
            this.lblTomorrow.AutoSize = true;
            this.lblTomorrow.Location = new System.Drawing.Point(23, 4);
            this.lblTomorrow.Name = "lblTomorrow";
            this.lblTomorrow.Size = new System.Drawing.Size(54, 13);
            this.lblTomorrow.TabIndex = 0;
            this.lblTomorrow.Text = "Tomorrow";
            // 
            // panDayAfter
            // 
            this.panDayAfter.Controls.Add(this.lblDayAfterDate);
            this.panDayAfter.Controls.Add(this.lblDayAfterConditions);
            this.panDayAfter.Controls.Add(this.pbDayAfterConditions);
            this.panDayAfter.Controls.Add(this.lblDayAfterTemp);
            this.panDayAfter.Controls.Add(this.lblDayAfter);
            this.panDayAfter.Location = new System.Drawing.Point(332, 10);
            this.panDayAfter.Name = "panDayAfter";
            this.panDayAfter.Size = new System.Drawing.Size(100, 150);
            this.panDayAfter.TabIndex = 2;
            // 
            // lblDayAfterDate
            // 
            this.lblDayAfterDate.AutoSize = true;
            this.lblDayAfterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAfterDate.Location = new System.Drawing.Point(31, 133);
            this.lblDayAfterDate.Name = "lblDayAfterDate";
            this.lblDayAfterDate.Size = new System.Drawing.Size(42, 17);
            this.lblDayAfterDate.TabIndex = 13;
            this.lblDayAfterDate.Text = "Date";
            // 
            // lblDayAfterConditions
            // 
            this.lblDayAfterConditions.AutoSize = true;
            this.lblDayAfterConditions.Location = new System.Drawing.Point(3, 93);
            this.lblDayAfterConditions.MaximumSize = new System.Drawing.Size(95, 40);
            this.lblDayAfterConditions.Name = "lblDayAfterConditions";
            this.lblDayAfterConditions.Size = new System.Drawing.Size(35, 13);
            this.lblDayAfterConditions.TabIndex = 12;
            this.lblDayAfterConditions.Text = "label1";
            // 
            // pbDayAfterConditions
            // 
            this.pbDayAfterConditions.Location = new System.Drawing.Point(28, 60);
            this.pbDayAfterConditions.Name = "pbDayAfterConditions";
            this.pbDayAfterConditions.Size = new System.Drawing.Size(45, 30);
            this.pbDayAfterConditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDayAfterConditions.TabIndex = 11;
            this.pbDayAfterConditions.TabStop = false;
            // 
            // lblDayAfterTemp
            // 
            this.lblDayAfterTemp.AutoSize = true;
            this.lblDayAfterTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAfterTemp.Location = new System.Drawing.Point(3, 29);
            this.lblDayAfterTemp.MaximumSize = new System.Drawing.Size(95, 0);
            this.lblDayAfterTemp.MinimumSize = new System.Drawing.Size(95, 0);
            this.lblDayAfterTemp.Name = "lblDayAfterTemp";
            this.lblDayAfterTemp.Size = new System.Drawing.Size(95, 22);
            this.lblDayAfterTemp.TabIndex = 10;
            this.lblDayAfterTemp.Text = "000";
            this.lblDayAfterTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDayAfter
            // 
            this.lblDayAfter.AutoSize = true;
            this.lblDayAfter.Location = new System.Drawing.Point(12, 4);
            this.lblDayAfter.Name = "lblDayAfter";
            this.lblDayAfter.Size = new System.Drawing.Size(76, 13);
            this.lblDayAfter.TabIndex = 0;
            this.lblDayAfter.Text = "Day After Next";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(10, 132);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 47);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(117, 166);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblLastUpdate.TabIndex = 4;
            this.lblLastUpdate.Text = "label1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(407, 164);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Location = new System.Drawing.Point(376, 164);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(25, 25);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmGlance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 191);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panDayAfter);
            this.Controls.Add(this.panTomorrow);
            this.Controls.Add(this.panToday);
            this.Controls.Add(this.panCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGlance";
            this.Text = "At A Glance";
            this.panCurrent.ResumeLayout(false);
            this.panCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentConditions)).EndInit();
            this.panToday.ResumeLayout(false);
            this.panToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayConditions)).EndInit();
            this.panTomorrow.ResumeLayout(false);
            this.panTomorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrowConditions)).EndInit();
            this.panDayAfter.ResumeLayout(false);
            this.panDayAfter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panCurrent;
        private System.Windows.Forms.Panel panToday;
        private System.Windows.Forms.Panel panTomorrow;
        private System.Windows.Forms.Panel panDayAfter;
        private System.Windows.Forms.Label lblCurrentTemp;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTomorrow;
        private System.Windows.Forms.Label lblDayAfter;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblCurrentConditions;
        private System.Windows.Forms.PictureBox pbCurrentConditions;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblTodayConditions;
        private System.Windows.Forms.PictureBox pbTodayConditions;
        private System.Windows.Forms.Label lblTodayTemp;
        private System.Windows.Forms.Label lblTomorrowDate;
        private System.Windows.Forms.Label lblTomorrowConditions;
        private System.Windows.Forms.PictureBox pbTomorrowConditions;
        private System.Windows.Forms.Label lblTomorrowTemp;
        private System.Windows.Forms.Label lblDayAfterDate;
        private System.Windows.Forms.Label lblDayAfterConditions;
        private System.Windows.Forms.PictureBox pbDayAfterConditions;
        private System.Windows.Forms.Label lblDayAfterTemp;
    }
}

