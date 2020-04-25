using System;

namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.minLabel1 = new System.Windows.Forms.Label();
            this.maxLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.minLabel2 = new System.Windows.Forms.Label();
            this.minLabel3 = new System.Windows.Forms.Label();
            this.minLabel4 = new System.Windows.Forms.Label();
            this.minLabel5 = new System.Windows.Forms.Label();
            this.minLabel6 = new System.Windows.Forms.Label();
            this.minLabel7 = new System.Windows.Forms.Label();
            this.maxLabel2 = new System.Windows.Forms.Label();
            this.maxLabel3 = new System.Windows.Forms.Label();
            this.maxLabel4 = new System.Windows.Forms.Label();
            this.maxLabel5 = new System.Windows.Forms.Label();
            this.maxLabel6 = new System.Windows.Forms.Label();
            this.maxLabel7 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.day7 = new System.Windows.Forms.Label();
            this.upTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.forecastLabel.Location = new System.Drawing.Point(129, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(115, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.todayLabel.Location = new System.Drawing.Point(22, 14);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(82, 28);
            this.todayLabel.TabIndex = 61;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click_1);
            // 
            // minLabel1
            // 
            this.minLabel1.AutoSize = true;
            this.minLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel1.Location = new System.Drawing.Point(210, 69);
            this.minLabel1.Name = "minLabel1";
            this.minLabel1.Size = new System.Drawing.Size(43, 23);
            this.minLabel1.TabIndex = 46;
            this.minLabel1.Text = " Min";
            // 
            // maxLabel1
            // 
            this.maxLabel1.AutoSize = true;
            this.maxLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel1.Location = new System.Drawing.Point(162, 69);
            this.maxLabel1.Name = "maxLabel1";
            this.maxLabel1.Size = new System.Drawing.Size(42, 23);
            this.maxLabel1.TabIndex = 44;
            this.maxLabel1.Text = "Max";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day1.Location = new System.Drawing.Point(13, 69);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(48, 23);
            this.day1.TabIndex = 64;
            this.day1.Text = "Date";
            // 
            // minLabel2
            // 
            this.minLabel2.AutoSize = true;
            this.minLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel2.Location = new System.Drawing.Point(210, 109);
            this.minLabel2.Name = "minLabel2";
            this.minLabel2.Size = new System.Drawing.Size(43, 23);
            this.minLabel2.TabIndex = 70;
            this.minLabel2.Text = " Min";
            // 
            // minLabel3
            // 
            this.minLabel3.AutoSize = true;
            this.minLabel3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel3.Location = new System.Drawing.Point(210, 149);
            this.minLabel3.Name = "minLabel3";
            this.minLabel3.Size = new System.Drawing.Size(43, 23);
            this.minLabel3.TabIndex = 71;
            this.minLabel3.Text = " Min";
            // 
            // minLabel4
            // 
            this.minLabel4.AutoSize = true;
            this.minLabel4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel4.Location = new System.Drawing.Point(210, 189);
            this.minLabel4.Name = "minLabel4";
            this.minLabel4.Size = new System.Drawing.Size(43, 23);
            this.minLabel4.TabIndex = 72;
            this.minLabel4.Text = " Min";
            // 
            // minLabel5
            // 
            this.minLabel5.AutoSize = true;
            this.minLabel5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel5.Location = new System.Drawing.Point(210, 229);
            this.minLabel5.Name = "minLabel5";
            this.minLabel5.Size = new System.Drawing.Size(43, 23);
            this.minLabel5.TabIndex = 73;
            this.minLabel5.Text = " Min";
            // 
            // minLabel6
            // 
            this.minLabel6.AutoSize = true;
            this.minLabel6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel6.Location = new System.Drawing.Point(210, 269);
            this.minLabel6.Name = "minLabel6";
            this.minLabel6.Size = new System.Drawing.Size(43, 23);
            this.minLabel6.TabIndex = 74;
            this.minLabel6.Text = " Min";
            // 
            // minLabel7
            // 
            this.minLabel7.AutoSize = true;
            this.minLabel7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minLabel7.Location = new System.Drawing.Point(210, 309);
            this.minLabel7.Name = "minLabel7";
            this.minLabel7.Size = new System.Drawing.Size(43, 23);
            this.minLabel7.TabIndex = 75;
            this.minLabel7.Text = " Min";
            // 
            // maxLabel2
            // 
            this.maxLabel2.AutoSize = true;
            this.maxLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel2.Location = new System.Drawing.Point(162, 109);
            this.maxLabel2.Name = "maxLabel2";
            this.maxLabel2.Size = new System.Drawing.Size(42, 23);
            this.maxLabel2.TabIndex = 76;
            this.maxLabel2.Text = "Max";
            // 
            // maxLabel3
            // 
            this.maxLabel3.AutoSize = true;
            this.maxLabel3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel3.Location = new System.Drawing.Point(162, 149);
            this.maxLabel3.Name = "maxLabel3";
            this.maxLabel3.Size = new System.Drawing.Size(42, 23);
            this.maxLabel3.TabIndex = 77;
            this.maxLabel3.Text = "Max";
            // 
            // maxLabel4
            // 
            this.maxLabel4.AutoSize = true;
            this.maxLabel4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel4.Location = new System.Drawing.Point(162, 189);
            this.maxLabel4.Name = "maxLabel4";
            this.maxLabel4.Size = new System.Drawing.Size(42, 23);
            this.maxLabel4.TabIndex = 78;
            this.maxLabel4.Text = "Max";
            // 
            // maxLabel5
            // 
            this.maxLabel5.AutoSize = true;
            this.maxLabel5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel5.Location = new System.Drawing.Point(162, 229);
            this.maxLabel5.Name = "maxLabel5";
            this.maxLabel5.Size = new System.Drawing.Size(42, 23);
            this.maxLabel5.TabIndex = 79;
            this.maxLabel5.Text = "Max";
            // 
            // maxLabel6
            // 
            this.maxLabel6.AutoSize = true;
            this.maxLabel6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel6.Location = new System.Drawing.Point(162, 269);
            this.maxLabel6.Name = "maxLabel6";
            this.maxLabel6.Size = new System.Drawing.Size(42, 23);
            this.maxLabel6.TabIndex = 80;
            this.maxLabel6.Text = "Max";
            // 
            // maxLabel7
            // 
            this.maxLabel7.AutoSize = true;
            this.maxLabel7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxLabel7.Location = new System.Drawing.Point(162, 309);
            this.maxLabel7.Name = "maxLabel7";
            this.maxLabel7.Size = new System.Drawing.Size(42, 23);
            this.maxLabel7.TabIndex = 81;
            this.maxLabel7.Text = "Max";
            // 
            // day2
            // 
            this.day2.AutoSize = true;
            this.day2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day2.Location = new System.Drawing.Point(13, 109);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(48, 23);
            this.day2.TabIndex = 82;
            this.day2.Text = "Date";
            // 
            // day3
            // 
            this.day3.AutoSize = true;
            this.day3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day3.Location = new System.Drawing.Point(13, 149);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(48, 23);
            this.day3.TabIndex = 83;
            this.day3.Text = "Date";
            // 
            // day4
            // 
            this.day4.AutoSize = true;
            this.day4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day4.Location = new System.Drawing.Point(13, 189);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(48, 23);
            this.day4.TabIndex = 84;
            this.day4.Text = "Date";
            // 
            // day5
            // 
            this.day5.AutoSize = true;
            this.day5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day5.Location = new System.Drawing.Point(13, 229);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(48, 23);
            this.day5.TabIndex = 85;
            this.day5.Text = "Date";
            // 
            // day6
            // 
            this.day6.AutoSize = true;
            this.day6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day6.Location = new System.Drawing.Point(13, 269);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(48, 23);
            this.day6.TabIndex = 86;
            this.day6.Text = "Date";
            // 
            // day7
            // 
            this.day7.AutoSize = true;
            this.day7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.day7.Location = new System.Drawing.Point(13, 309);
            this.day7.Name = "day7";
            this.day7.Size = new System.Drawing.Size(48, 23);
            this.day7.TabIndex = 87;
            this.day7.Text = "Date";
            // 
            // upTimeLabel
            // 
            this.upTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.upTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.upTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upTimeLabel.Location = new System.Drawing.Point(24, 377);
            this.upTimeLabel.Name = "upTimeLabel";
            this.upTimeLabel.Size = new System.Drawing.Size(209, 23);
            this.upTimeLabel.TabIndex = 88;
            this.upTimeLabel.Text = "Last Updated";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(125, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 91;
            this.label1.Text = "____________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(112, 309);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 98;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(112, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 97;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(112, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 96;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(112, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 95;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(112, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 94;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(112, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::XMLWeather.Properties.Resources.cloud;
            this.pictureBox1.Image = global::XMLWeather.Properties.Resources.cloud;
            this.pictureBox1.InitialImage = global::XMLWeather.Properties.Resources.Rain3;
            this.pictureBox1.Location = new System.Drawing.Point(112, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upTimeLabel);
            this.Controls.Add(this.day7);
            this.Controls.Add(this.day6);
            this.Controls.Add(this.day5);
            this.Controls.Add(this.day4);
            this.Controls.Add(this.day3);
            this.Controls.Add(this.day2);
            this.Controls.Add(this.maxLabel7);
            this.Controls.Add(this.maxLabel6);
            this.Controls.Add(this.maxLabel5);
            this.Controls.Add(this.maxLabel4);
            this.Controls.Add(this.maxLabel3);
            this.Controls.Add(this.maxLabel2);
            this.Controls.Add(this.minLabel7);
            this.Controls.Add(this.minLabel6);
            this.Controls.Add(this.minLabel5);
            this.Controls.Add(this.minLabel4);
            this.Controls.Add(this.minLabel3);
            this.Controls.Add(this.minLabel2);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.minLabel1);
            this.Controls.Add(this.maxLabel1);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.ForecastScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label minLabel1;
        private System.Windows.Forms.Label maxLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label minLabel2;
        private System.Windows.Forms.Label minLabel3;
        private System.Windows.Forms.Label minLabel4;
        private System.Windows.Forms.Label minLabel5;
        private System.Windows.Forms.Label minLabel6;
        private System.Windows.Forms.Label minLabel7;
        private System.Windows.Forms.Label maxLabel2;
        private System.Windows.Forms.Label maxLabel3;
        private System.Windows.Forms.Label maxLabel4;
        private System.Windows.Forms.Label maxLabel5;
        private System.Windows.Forms.Label maxLabel6;
        private System.Windows.Forms.Label maxLabel7;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Label day7;
        private System.Windows.Forms.Label upTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}
