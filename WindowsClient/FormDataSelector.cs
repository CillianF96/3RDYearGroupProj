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

namespace ProductTracking
{
    public partial class FormDataSelector : Form
    {
        IModel Model;
        public FormDataSelector(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void btnMonthlyData_Click(object sender, EventArgs e)
        {
            formData fd = new formData(Model);
            fd.Show();
        }

        private void btnBusiestDay_Click(object sender, EventArgs e)
        {
            busiestDayForm bd = new busiestDayForm(Model);
            bd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
