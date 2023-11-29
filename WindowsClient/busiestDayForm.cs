using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProductTracking
{
    public partial class busiestDayForm : Form
    {
        IModel Model;

        public busiestDayForm(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void busiestDayForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<IReservation> roomResList = Model.ReservationList;

            List<DateTime> dates = new List<DateTime>();
            foreach (IReservation res in roomResList)
            {
                dates.Add(res.Date);
            }
            int[] daysOfWeek = new int[7];

            foreach (DateTime date in dates)
            {
                //date.DayOfWeek.ToString();

                switch (date.DayOfWeek.ToString())
                {
                    case "Monday":
                        daysOfWeek[0]++;
                        break;
                    case "Tuesday":
                        daysOfWeek[1]++;
                        break;
                    case "Wednesday":
                        daysOfWeek[2]++;
                        break;
                    case "Thursday":
                        daysOfWeek[3]++;
                        break;
                    case "Friday":
                        daysOfWeek[4]++;
                        break;
                    case "Saturday":
                        daysOfWeek[5]++;
                        break;
                    case "Sunday":
                        daysOfWeek[6]++;
                        break;
                }
            }
            string[] dayLabels = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Series dataSeries = new Series("Busiest Day Data");
            dataSeries.ChartType = SeriesChartType.Column;


            for (int i = 0; i < dayLabels.Length; i++)
            {
                dataSeries.Points.AddXY(dayLabels[i], daysOfWeek[i]);
            }

            chart1.Series.Add(dataSeries);

            chart1.Titles.Add("Number of people per day");
            chart1.ChartAreas[0].AxisX.Title = "Day of the Week";
            chart1.ChartAreas[0].AxisY.Title = "Number of People";

            double maxValue = 0;
            DataPoint maxDataPoint = null;
            foreach (DataPoint point in dataSeries.Points)
            {
                if (point.YValues[0] > maxValue)
                {
                    maxValue = point.YValues[0];
                    maxDataPoint = point;
                }
            }

            if (maxDataPoint != null)
            {
                maxDataPoint.Color = Color.Green; // Set your desired color
            }

            chart1.Invalidate();

        }

        private void btnSelectedData_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<IReservation> roomResList = Model.ReservationList;

            List<DateTime> dates = new List<DateTime>();
            foreach (IReservation res in roomResList)
            {
                if (res.Date >= dtpStart.Value && res.Date <= dtpEnd.Value)
                {
                    dates.Add(res.Date);
                }
            }
            int[] daysOfWeek = new int[7];

            foreach (DateTime date in dates)
            {
                //date.DayOfWeek.ToString();

                switch (date.DayOfWeek.ToString())
                {
                    case "Monday":
                        daysOfWeek[0]++;
                        break;
                    case "Tuesday":
                        daysOfWeek[1]++;
                        break;
                    case "Wednesday":
                        daysOfWeek[2]++;
                        break;
                    case "Thursday":
                        daysOfWeek[3]++;
                        break;
                    case "Friday":
                        daysOfWeek[4]++;
                        break;
                    case "Saturday":
                        daysOfWeek[5]++;
                        break;
                    case "Sunday":
                        daysOfWeek[6]++;
                        break;
                }
            }
            string[] dayLabels = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Series dataSeries = new Series("Busiest Day Data");
            dataSeries.ChartType = SeriesChartType.Column;


            for (int i = 0; i < dayLabels.Length; i++)
            {
                dataSeries.Points.AddXY(dayLabels[i], daysOfWeek[i]);
            }

            chart1.Series.Add(dataSeries);

            double maxValue = 0;
            DataPoint maxDataPoint = null;
            foreach (DataPoint point in dataSeries.Points)
            {
                if (point.YValues[0] > maxValue)
                {
                    maxValue = point.YValues[0];
                    maxDataPoint = point;
                }
            }

            if (maxDataPoint != null)
            {
                maxDataPoint.Color = Color.Green;
            }

            chart1.Invalidate();

        }

        private void btnDaysData_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
