using BusinessLayer;
using BusinessEntities;
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
    public partial class formData : Form
    {
        IModel Model;
        public formData(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void formData_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                List<IReservation> roomResList = Model.ReservationList;

                List<double> billList = new List<double>();
                List<DateTime> dateList = new List<DateTime>();
                double total = 0;
                foreach (IReservation res in roomResList)
                {                
                    billList.Add(res.Bill);
                    total += res.Bill;
                }



                foreach (IReservation res2 in roomResList)
                {
                    dateList.Add(res2.Date);
                }

               


                Series dataSeries = new Series("Reservation Data");

                dataSeries.ChartType = SeriesChartType.Column;

                // add to series
                for (int i = 0; i < billList.Count; i++)
                {
                    dataSeries.Points.AddXY(dateList[i], billList[i]);
                }
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

                // Add the series to the chart
                chart1.Series.Add(dataSeries);

                chart1.Titles.Add("Revenue From Room Sales Per Week"); 
                chart1.ChartAreas[0].AxisX.Title = "Week";
                chart1.ChartAreas[0].AxisY.Title = "Bill Amount";


                List<IReservation> roomResList2 = Model.ReservationList;
                

             


                txtboxTotal.Text = total.ToString();

                // Refresh the chart
                chart1.Invalidate();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeChart()
        {
           
        }

        private void txtboxTotal_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            chart1.Series.Clear();
            List<IReservation> roomResList = Model.ReservationList;

            List<double> billList = new List<double>();
            List<DateTime> dateList = new List<DateTime>();
            double total = 0;
            foreach (IReservation res in roomResList)
            {
                if (res.Date >= dtpStart.Value && res.Date <= dtpEnd.Value)
                {
                    dateList.Add(res.Date);
                    billList.Add(res.Bill);
                    total += res.Bill;
                }

            }
            Series dataSeries = new Series("Reservation Data");

            for (int i = 0; i < billList.Count; i++)
            {
                dataSeries.Points.AddXY(dateList[i], billList[i]);
            }


            dataSeries.ChartType = SeriesChartType.Column;
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

            txtboxTotal.Text = total.ToString();

            chart1.Invalidate();
        }

        private void btnCloseRoomData_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
