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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
            todayWeather();
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there

            //city
            cityOutput.Text = Form1.days[0].location;

            //conditions
            conditionLabel.Text = Form1.days[0].condition;

            //temp
            tempLabel.Text = Math.Round
                (Convert.ToDouble(Form1.days[0].currentTemp), 0) + "° ";

            //local time converted to time in location
            dateLabel.Text = DateTime.Now.AddSeconds(-14400).ToString("dddd") + "  |  "
                + DateTime.Now.AddSeconds(-14400).ToString("MMM dd") + "  |  " + DateTime.Now.ToString("yyyy");


            //min and max
            minOutput.Text = Math.Round 
                (Convert.ToDouble(Form1.days[0].tempLow), 0) + "° ";
            maxOutput.Text = Math.Round 
                (Convert.ToDouble(Form1.days[0].tempHigh), 0) + "° ";

            //sun
            sunriseLabel.Text = Convert.ToDateTime(Form1.days[0].sunrise).AddSeconds(-14400).ToString("h:mm tt");
            sunsetLabel.Text = Convert.ToDateTime(Form1.days[0].sunset).AddSeconds(-14400).ToString("h:mm tt");

            //wind vector

            windLabel.Text = Math.Round((3600/1000) * Convert.ToDouble(Form1.days[0].windSpeed), 0) + " km/h";
            windLabel.Text += " " + Form1.days[0].windDirection;

            //update time
            upTimeLabel.Text = "Last Updated at " + Convert.ToDateTime(Form1.days[0].updateTime).AddSeconds(-14400).ToString("h:mm tt");



        }
        public void todayWeather()
        {
            if (Form1.days[0].code == "11d")
            {
                pBox.Image = XMLWeather.Properties.Resources.storm;
                this.BackgroundImage = XMLWeather.Properties.Resources.storm1;
            }
            else if (Form1.days[0].code == "09d")
            {
                pBox.Image = XMLWeather.Properties.Resources.rain;
                this.BackgroundImage = XMLWeather.Properties.Resources.rain2;
            }
            else if (Form1.days[0].code == "10d")
            {
                pBox.Image = XMLWeather.Properties.Resources.rain;
                this.BackgroundImage = XMLWeather.Properties.Resources.rain2;
            }
            else if (Form1.days[0].code == "13d")
            {
                pBox.Image = XMLWeather.Properties.Resources.snow;
                this.BackgroundImage = XMLWeather.Properties.Resources.snow2;
            }
            else if (Form1.days[0].code == "50d")
            {
                pBox.Image = XMLWeather.Properties.Resources.cloud_wind;
                this.BackgroundImage = XMLWeather.Properties.Resources.wind;
            }
            else if (Form1.days[0].code == "01d")
            {
                pBox.Image = XMLWeather.Properties.Resources.sun;
                this.BackgroundImage = XMLWeather.Properties.Resources.sun1;
            }
            else if (Form1.days[0].code == "02d" || Form1.days[0].code == "03d" || Form1.days[0].code == "04d")
            {
                pBox.Image = XMLWeather.Properties.Resources.cloudS;
                this.BackgroundImage = XMLWeather.Properties.Resources.cloudS2;
            }
            else if (Form1.days[0].code == "01n")
            {
                pBox.Image = XMLWeather.Properties.Resources.moon;
                this.BackgroundImage = XMLWeather.Properties.Resources.Moon1;
            }
            else if (Form1.days[0].code == "02n" || Form1.days[0].code == "03n" || Form1.days[0].code == "04n")
            {
                pBox.Image = XMLWeather.Properties.Resources.cloudM;
                this.BackgroundImage = XMLWeather.Properties.Resources.cloudM2;
            }

            pBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pBox.Visible = true;
            this.Focus();
            this.Refresh();
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
            fs.Focus();
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
