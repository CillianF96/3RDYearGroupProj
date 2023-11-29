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
    public partial class formOperator : Form
    {
        private formContainer fc;
        private IModel Model;
        public formOperator(formContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
            Model.populateOrders(); // lazy load the orders ie we will only construct the order objects and fill the models orderList if the user is going into the Production side of the application
                                    // lazy load in this context just means that we did not load them in the Model constructor as we may never need the order objects, as it depends on what areas of the 
                                    // UI the user navigates to. We won't load any orders unless user navigates to an area of the UI dealing with orders . 
                                    // The populateOrders() method also manages setting up the linked ProductLine objects for each order.
                                    // an order can have one or many productLines so need to setup ProductLineList in each order object.
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }

        private void buttonAllocatePreparedProduct_Click(object sender, EventArgs e)
        {
            formAllocatePreparedProduct form = new formAllocatePreparedProduct(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void buttonViewOrderDetails_Click(object sender, EventArgs e)
        {
            formViewOrderDetails form = new formViewOrderDetails(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
