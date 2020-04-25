using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }



        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {

            //display days, account for different time zones
            day1.Text = "Today";
            day2.Text = DateTime.Now.AddDays(1).AddSeconds(-14400).ToString("dddd");
            day3.Text = DateTime.Now.AddDays(2).AddSeconds(-14400).ToString("dddd");
            day4.Text = DateTime.Now.AddDays(3).AddSeconds(-14400).ToString("dddd");
            day5.Text = DateTime.Now.AddDays(4).AddSeconds(-14400).ToString("dddd");
            day6.Text = DateTime.Now.AddDays(5).AddSeconds(-14400).ToString("dddd");
            day7.Text = DateTime.Now.AddDays(6).AddSeconds(-14400).ToString("dddd");


            //day1
            minLabel1.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0) + "° ";
            maxLabel1.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0) + "° ";

            //day2
            minLabel2.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow), 0) + "° ";
            maxLabel2.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh), 0) + "° ";

            //day3
            minLabel3.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow), 0) + "° ";
            maxLabel3.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh), 0) + "° ";

            //day4
            minLabel4.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow), 0) + "° ";
            maxLabel4.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh), 0) + "° ";

            //day5
            minLabel5.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow), 0) + "° ";
            maxLabel5.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh), 0) + "° ";

            //day6
            minLabel6.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow), 0) + "° ";
            maxLabel6.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh), 0) + "° ";

            //day7
            minLabel7.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow), 0) + "° ";
            maxLabel7.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh), 0) + "° ";



            //update time
            upTimeLabel.Text = "Last Updated at " + Convert.ToDateTime(Form1.days[0].updateTime).AddSeconds(-14400).ToString("h:mm tt");



        }
            /// <summary>
            /// When the Today label is clicked, this user control is removed from the form
            /// and the CurrentScreen user control is added to the form.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

        private void ForecastScreen_Load(object sender, EventArgs e)
            {
            //display a wallpaper and the icon of the waether for each day

            //day 1
            if (Form1.days[0].code == "11d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.storm;
                this.BackgroundImage = XMLWeather.Properties.Resources.storm1;
            }
            else if (Form1.days[0].code == "09d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.rain;
                this.BackgroundImage = XMLWeather.Properties.Resources.rain2;
            }
            else if (Form1.days[0].code == "10d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.rain;
                this.BackgroundImage = XMLWeather.Properties.Resources.rain2;
            }
            else if (Form1.days[0].code == "13d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.snow;
                this.BackgroundImage = XMLWeather.Properties.Resources.snow2;
            }
            else if (Form1.days[0].code == "50d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.cloud_wind;
                this.BackgroundImage = XMLWeather.Properties.Resources.wind;
            }
            else if (Form1.days[0].code == "01d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.sun;
                this.BackgroundImage = XMLWeather.Properties.Resources.sun1;
            }
            else if (Form1.days[0].code == "02d" || Form1.days[0].code == "03d" || Form1.days[0].code == "04d")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.cloudS;
                this.BackgroundImage = XMLWeather.Properties.Resources.cloudS2;
            }
            else if (Form1.days[0].code == "01n")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.moon;
                this.BackgroundImage = XMLWeather.Properties.Resources.Moon1;
            }
            else if (Form1.days[0].code == "02n" || Form1.days[0].code == "03n" || Form1.days[0].code == "04n")
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.cloudM;
                this.BackgroundImage = XMLWeather.Properties.Resources.cloudM2;
            }


            //day 2
            if (Form1.days[1].code == "11d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.storm;

            }
            else if (Form1.days[1].code == "09d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[1].code == "10d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[1].code == "13d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.snow;

            }
            else if (Form1.days[1].code == "50d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.cloud_wind;

            }
            else if (Form1.days[1].code == "01d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.sun;

            }
            else if (Form1.days[1].code == "02d" || Form1.days[1].code == "03d" || Form1.days[1].code == "04d")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.cloudS;
            }
            else if (Form1.days[1].code == "01n")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.moon;

            }
            else if (Form1.days[1].code == "02n" || Form1.days[1].code == "03n" || Form1.days[1].code == "04n")
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.cloudM;
            }


            //day 3
            if (Form1.days[2].code == "11d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.storm;

            }
            else if (Form1.days[2].code == "09d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[2].code == "10d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[2].code == "13d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.snow;

            }
            else if (Form1.days[2].code == "50d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.cloud_wind;

            }
            else if (Form1.days[2].code == "01d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.sun;

            }
            else if (Form1.days[2].code == "02d" || Form1.days[2].code == "03d" || Form1.days[2].code == "04d")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.cloudS;
            }
            else if (Form1.days[2].code == "01n")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.moon;

            }
            else if (Form1.days[2].code == "02n" || Form1.days[2].code == "03n" || Form1.days[2].code == "04n")
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.cloudM;
            }



            //day 4
            if (Form1.days[3].code == "11d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.storm;

            }
            else if (Form1.days[3].code == "09d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[3].code == "10d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[3].code == "13d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.snow;

            }
            else if (Form1.days[3].code == "50d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.cloud_wind;

            }
            else if (Form1.days[3].code == "01d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.sun;

            }
            else if (Form1.days[3].code == "02d" || Form1.days[3].code == "03d" || Form1.days[3].code == "04d")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.cloudS;
            }
            else if (Form1.days[3].code == "01n")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.moon;

            }
            else if (Form1.days[3].code == "02n" || Form1.days[3].code == "03n" || Form1.days[3].code == "04n")
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.cloudM;
            }


            //day 5
            if (Form1.days[4].code == "11d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.storm;

            }
            else if (Form1.days[4].code == "09d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[4].code == "10d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[4].code == "13d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.snow;

            }
            else if (Form1.days[4].code == "50d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.cloud_wind;

            }
            else if (Form1.days[4].code == "01d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.sun;

            }
            else if (Form1.days[4].code == "02d" || Form1.days[4].code == "03d" || Form1.days[4].code == "04d")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.cloudS;
            }
            else if (Form1.days[4].code == "01n")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.moon;

            }
            else if (Form1.days[4].code == "02n" || Form1.days[4].code == "03n" || Form1.days[4].code == "04n")
            {
                pictureBox5.Image = XMLWeather.Properties.Resources.cloudM;
            }


            //day 6
            if (Form1.days[5].code == "11d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.storm;

            }
            else if (Form1.days[5].code == "09d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[5].code == "10d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[5].code == "13d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.snow;

            }
            else if (Form1.days[5].code == "50d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.cloud_wind;

            }
            else if (Form1.days[5].code == "01d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.sun;

            }
            else if (Form1.days[5].code == "02d" || Form1.days[5].code == "03d" || Form1.days[5].code == "04d")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.cloudS;
            }
            else if (Form1.days[5].code == "01n")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.moon;

            }
            else if (Form1.days[5].code == "02n" || Form1.days[5].code == "03n" || Form1.days[5].code == "04n")
            {
                pictureBox6.Image = XMLWeather.Properties.Resources.cloudM;
            }


            //day 7
            if (Form1.days[6].code == "11d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.storm;

            }
            else if (Form1.days[6].code == "09d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[6].code == "10d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.rain;

            }
            else if (Form1.days[6].code == "13d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.snow;

            }
            else if (Form1.days[6].code == "50d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.cloud_wind;

            }
            else if (Form1.days[6].code == "01d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.sun;

            }
            else if (Form1.days[6].code == "02d" || Form1.days[6].code == "03d" || Form1.days[6].code == "04d")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.cloudS;
            }
            else if (Form1.days[6].code == "01n")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.moon;

            }
            else if (Form1.days[6].code == "02n" || Form1.days[6].code == "03n" || Form1.days[6].code == "04n")
            {
                pictureBox7.Image = XMLWeather.Properties.Resources.cloudM;
            }


            //crop the icons to fit
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void todayLabel_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void drawBackground(object sender, EventArgs e)
        {

        }
    }
}
