using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;
using System.Runtime.InteropServices;

namespace ProductTracking
{
    public partial class formMonthlyData : Form
    {
        IModel Model;
        public formMonthlyData(IModel _model) 
        {
            InitializeComponent();
            Model = _model;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayReservations()
        {
            var roomResList = Model.ReservationList.OfType<RoomReservation>().ToList();

            roomReservationBindingSource.DataSource = roomResList;

            for (int i = 0; i < roomResList.Count; i++)
            {
                dgvStaffMain.Rows[i].Cells["colResName"].Value = roomResList[i].Person.FullName;
            }
            dgvStaffMain.Columns["timeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = @"hh\:mm";
        }
    }
}
