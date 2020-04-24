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
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there

            //city
            cityOutput.Text = Form1.days[0].location;

            //temp
            tempLabel.Text = Math.Round
                (Convert.ToDouble(Form1.days[0].currentTemp), 0) + "° ";

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
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
