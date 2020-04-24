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
            day7.Text = DateTime.Now.AddDays(6).AddSeconds(- 14400).ToString("dddd");


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
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
