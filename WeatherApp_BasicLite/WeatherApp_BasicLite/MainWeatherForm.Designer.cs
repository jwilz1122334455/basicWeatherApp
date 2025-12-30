namespace WeatherApp_BasicLite
{
    partial class MainWeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWeatherForm));
            label1 = new Label();
            TxtCity = new TextBox();
            BtnSearch = new Button();
            LblCondition = new Label();
            LblDetail = new Label();
            label4 = new Label();
            label5 = new Label();
            LblSunrise = new Label();
            LblSunset = new Label();
            LblPressure = new Label();
            LblWind = new Label();
            label8 = new Label();
            label9 = new Label();
            PicIcon = new PictureBox();
            LblCity = new Label();
            LblCountry = new Label();
            LblTemp = new Label();
            LblHumid = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            LblTempMin = new Label();
            LblTempMax = new Label();
            LblFeelsLike = new Label();
            label12 = new Label();
            LblCloudCover = new Label();
            label10 = new Label();
            LblVisibility = new Label();
            label13 = new Label();
            LblLastUpdate = new Label();
            ((System.ComponentModel.ISupportInitialize)PicIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 78);
            label1.Name = "label1";
            label1.Size = new Size(85, 38);
            label1.TabIndex = 0;
            label1.Text = "CITY:";
            // 
            // TxtCity
            // 
            TxtCity.BackColor = Color.White;
            TxtCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCity.Location = new Point(199, 78);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(539, 45);
            TxtCity.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.Transparent;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSearch.ForeColor = Color.White;
            BtnSearch.Location = new Point(767, 73);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(110, 43);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // LblCondition
            // 
            LblCondition.AutoSize = true;
            LblCondition.BackColor = Color.Black;
            LblCondition.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCondition.ForeColor = Color.White;
            LblCondition.Location = new Point(94, 261);
            LblCondition.Name = "LblCondition";
            LblCondition.Size = new Size(141, 38);
            LblCondition.TabIndex = 3;
            LblCondition.Text = "Condition";
            // 
            // LblDetail
            // 
            LblDetail.AutoSize = true;
            LblDetail.BackColor = Color.Black;
            LblDetail.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDetail.ForeColor = Color.White;
            LblDetail.Location = new Point(94, 321);
            LblDetail.Name = "LblDetail";
            LblDetail.Size = new Size(103, 38);
            LblDetail.TabIndex = 4;
            LblDetail.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(707, 500);
            label4.Name = "label4";
            label4.Size = new Size(108, 38);
            label4.TabIndex = 5;
            label4.Text = "Sunset:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(707, 442);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 6;
            label5.Text = "Sunrise:";
            // 
            // LblSunrise
            // 
            LblSunrise.AutoSize = true;
            LblSunrise.BackColor = Color.Black;
            LblSunrise.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSunrise.ForeColor = Color.White;
            LblSunrise.Location = new Point(979, 442);
            LblSunrise.Name = "LblSunrise";
            LblSunrise.Size = new Size(69, 38);
            LblSunrise.TabIndex = 7;
            LblSunrise.Text = "N/A";
            // 
            // LblSunset
            // 
            LblSunset.AutoSize = true;
            LblSunset.BackColor = Color.Black;
            LblSunset.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSunset.ForeColor = Color.White;
            LblSunset.Location = new Point(979, 500);
            LblSunset.Name = "LblSunset";
            LblSunset.Size = new Size(69, 38);
            LblSunset.TabIndex = 8;
            LblSunset.Text = "N/A";
            // 
            // LblPressure
            // 
            LblPressure.AutoSize = true;
            LblPressure.BackColor = Color.Black;
            LblPressure.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPressure.ForeColor = Color.White;
            LblPressure.Location = new Point(367, 438);
            LblPressure.Name = "LblPressure";
            LblPressure.Size = new Size(69, 38);
            LblPressure.TabIndex = 12;
            LblPressure.Text = "N/A";
            // 
            // LblWind
            // 
            LblWind.AutoSize = true;
            LblWind.BackColor = Color.Black;
            LblWind.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblWind.ForeColor = Color.White;
            LblWind.Location = new Point(367, 379);
            LblWind.Name = "LblWind";
            LblWind.Size = new Size(69, 38);
            LblWind.TabIndex = 11;
            LblWind.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(94, 379);
            label8.Name = "label8";
            label8.Size = new Size(175, 38);
            label8.TabIndex = 10;
            label8.Text = "Wind speed:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(94, 438);
            label9.Name = "label9";
            label9.Size = new Size(130, 38);
            label9.TabIndex = 9;
            label9.Text = "Pressure:";
            // 
            // PicIcon
            // 
            PicIcon.BackColor = Color.Black;
            PicIcon.Location = new Point(927, 153);
            PicIcon.Name = "PicIcon";
            PicIcon.Size = new Size(116, 92);
            PicIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PicIcon.TabIndex = 13;
            PicIcon.TabStop = false;
            // 
            // LblCity
            // 
            LblCity.AutoSize = true;
            LblCity.BackColor = Color.Black;
            LblCity.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCity.ForeColor = Color.White;
            LblCity.Location = new Point(85, 149);
            LblCity.Name = "LblCity";
            LblCity.Size = new Size(251, 60);
            LblCity.TabIndex = 14;
            LblCity.Text = "CITYNAME";
            LblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCountry
            // 
            LblCountry.AutoSize = true;
            LblCountry.BackColor = Color.Black;
            LblCountry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCountry.ForeColor = Color.White;
            LblCountry.Location = new Point(94, 209);
            LblCountry.Name = "LblCountry";
            LblCountry.Size = new Size(207, 32);
            LblCountry.TabIndex = 15;
            LblCountry.Text = "COUNTRY NAME";
            // 
            // LblTemp
            // 
            LblTemp.AutoSize = true;
            LblTemp.BackColor = Color.Black;
            LblTemp.Font = new Font("Agency FB", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTemp.ForeColor = Color.White;
            LblTemp.Location = new Point(701, 153);
            LblTemp.Name = "LblTemp";
            LblTemp.Size = new Size(104, 53);
            LblTemp.TabIndex = 16;
            LblTemp.Text = "TEMP";
            // 
            // LblHumid
            // 
            LblHumid.AutoSize = true;
            LblHumid.BackColor = Color.Black;
            LblHumid.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblHumid.ForeColor = Color.White;
            LblHumid.Location = new Point(367, 497);
            LblHumid.Name = "LblHumid";
            LblHumid.Size = new Size(69, 38);
            LblHumid.TabIndex = 18;
            LblHumid.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 497);
            label3.Name = "label3";
            label3.Size = new Size(141, 38);
            label3.TabIndex = 17;
            label3.Text = "Humidity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(703, 265);
            label2.Name = "label2";
            label2.Size = new Size(73, 38);
            label2.TabIndex = 19;
            label2.Text = "Min:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(889, 265);
            label6.Name = "label6";
            label6.Size = new Size(79, 38);
            label6.TabIndex = 20;
            label6.Text = "Max:";
            // 
            // LblTempMin
            // 
            LblTempMin.AutoSize = true;
            LblTempMin.BackColor = Color.Black;
            LblTempMin.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTempMin.ForeColor = Color.White;
            LblTempMin.Location = new Point(782, 265);
            LblTempMin.Name = "LblTempMin";
            LblTempMin.Size = new Size(69, 38);
            LblTempMin.TabIndex = 21;
            LblTempMin.Text = "N/A";
            // 
            // LblTempMax
            // 
            LblTempMax.AutoSize = true;
            LblTempMax.BackColor = Color.Black;
            LblTempMax.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTempMax.ForeColor = Color.White;
            LblTempMax.Location = new Point(974, 265);
            LblTempMax.Name = "LblTempMax";
            LblTempMax.Size = new Size(69, 38);
            LblTempMax.TabIndex = 22;
            LblTempMax.Text = "N/A";
            // 
            // LblFeelsLike
            // 
            LblFeelsLike.AutoSize = true;
            LblFeelsLike.BackColor = Color.Black;
            LblFeelsLike.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFeelsLike.ForeColor = Color.White;
            LblFeelsLike.Location = new Point(818, 212);
            LblFeelsLike.Name = "LblFeelsLike";
            LblFeelsLike.Size = new Size(58, 32);
            LblFeelsLike.TabIndex = 25;
            LblFeelsLike.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Black;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(703, 212);
            label12.Name = "label12";
            label12.Size = new Size(119, 32);
            label12.TabIndex = 23;
            label12.Text = "Feels like:";
            // 
            // LblCloudCover
            // 
            LblCloudCover.AutoSize = true;
            LblCloudCover.BackColor = Color.Black;
            LblCloudCover.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCloudCover.ForeColor = Color.White;
            LblCloudCover.Location = new Point(979, 325);
            LblCloudCover.Name = "LblCloudCover";
            LblCloudCover.Size = new Size(69, 38);
            LblCloudCover.TabIndex = 27;
            LblCloudCover.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(706, 325);
            label10.Name = "label10";
            label10.Size = new Size(222, 38);
            label10.TabIndex = 26;
            label10.Text = "Cloud coverage:";
            // 
            // LblVisibility
            // 
            LblVisibility.AutoSize = true;
            LblVisibility.BackColor = Color.Black;
            LblVisibility.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblVisibility.ForeColor = Color.White;
            LblVisibility.Location = new Point(979, 383);
            LblVisibility.Name = "LblVisibility";
            LblVisibility.Size = new Size(69, 38);
            LblVisibility.TabIndex = 29;
            LblVisibility.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Black;
            label13.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(706, 383);
            label13.Name = "label13";
            label13.Size = new Size(130, 38);
            label13.TabIndex = 28;
            label13.Text = "Visibility:";
            // 
            // LblLastUpdate
            // 
            LblLastUpdate.AutoSize = true;
            LblLastUpdate.BackColor = Color.Black;
            LblLastUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLastUpdate.ForeColor = Color.White;
            LblLastUpdate.Location = new Point(94, 578);
            LblLastUpdate.Name = "LblLastUpdate";
            LblLastUpdate.Size = new Size(133, 25);
            LblLastUpdate.TabIndex = 30;
            LblLastUpdate.Text = "LASTUPDATED";
            LblLastUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainWeatherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1138, 646);
            Controls.Add(LblLastUpdate);
            Controls.Add(LblVisibility);
            Controls.Add(label13);
            Controls.Add(LblCloudCover);
            Controls.Add(label10);
            Controls.Add(LblFeelsLike);
            Controls.Add(label12);
            Controls.Add(LblTempMax);
            Controls.Add(LblTempMin);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(LblHumid);
            Controls.Add(label3);
            Controls.Add(LblTemp);
            Controls.Add(LblCountry);
            Controls.Add(LblCity);
            Controls.Add(PicIcon);
            Controls.Add(LblPressure);
            Controls.Add(LblWind);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(LblSunset);
            Controls.Add(LblSunrise);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LblDetail);
            Controls.Add(LblCondition);
            Controls.Add(BtnSearch);
            Controls.Add(TxtCity);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWeatherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WEATHER LITE";
            ((System.ComponentModel.ISupportInitialize)PicIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtCity;
        private Button BtnSearch;
        private Label LblCondition;
        private Label LblDetail;
        private Label label4;
        private Label label5;
        private Label LblSunrise;
        private Label LblSunset;
        private Label LblPressure;
        private Label LblWind;
        private Label label8;
        private Label label9;
        private PictureBox PicIcon;
        private Label LblCity;
        private Label LblCountry;
        private Label LblTemp;
        private Label LblHumid;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label LblTempMin;
        private Label LblTempMax;
        private Label LblFeelsLike;
        private Label label12;
        private Label LblCloudCover;
        private Label label10;
        private Label LblVisibility;
        private Label label13;
        private Label LblLastUpdate;
    }
}
