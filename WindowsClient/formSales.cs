using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace ProductTracking
{
    public partial class formSales : Form
    {
        #region Instance Attributes
        private formContainer fc;
        private IModel Model;
        #endregion
        #region Constructors
        public formSales(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //if (Model.Con.State.ToString() == "Open")
            //    Model.Con.Close();
            Application.Exit();
        }
    }
}
