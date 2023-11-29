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

namespace ProductTracking
{
    public partial class formViewOrderDetails : Form
    {
        private IModel Model;
        formContainer fc;
        public formViewOrderDetails(formContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
        }

        private void formViewOrderDetails_Load(object sender, EventArgs e)
        {
            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Order Number";
            colHead.Width = listViewOrders.Width / 7;
            listViewOrders.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "ProductLine No";
            listViewOrders.Columns.Add(colHead);
            colHead.Width = listViewOrders.Width / 7;
            colHead = new ColumnHeader();
            colHead.Text = "Order Date";
            colHead.Width = listViewOrders.Width / 7;
            listViewOrders.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Complete";
            listViewOrders.Columns.Add(colHead);
            colHead.Width = listViewOrders.Width / 7;
            colHead = new ColumnHeader();
            colHead.Text = "Product Code";
            listViewOrders.Columns.Add(colHead);
            colHead.Width = listViewOrders.Width / 7;
            colHead = new ColumnHeader();
            colHead.Text = "Qty Ordered";
            listViewOrders.Columns.Add(colHead);
            colHead.Width = listViewOrders.Width / 7;
            colHead = new ColumnHeader();
            colHead.Text = "Qty Prepared";
            listViewOrders.Columns.Add(colHead);
            colHead.Width = listViewOrders.Width / 7;

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1, lvsi2, lvsi3, lvsi4;
            listViewOrders.Items.Clear();
            listViewOrders.BeginUpdate();


            foreach (Order order in Model.OrderList)
            {
                foreach (ProductLine productLine in order.ProductLineList)
                {
                    lvi = new ListViewItem();
                    lvi.Text = order.OrderCode.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductLineCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = order.OrderDate.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.Complete.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyRequired.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyPrepared.ToString();
                    lvi.SubItems.Add(lvsi1);
                    listViewOrders.Items.Add(lvi);

                }
            }
            listViewOrders.EndUpdate();

            listViewOrders.Items[1].BackColor = Color.Yellow; // highlight a row TBD
            listViewOrders.Enabled = true;
            listViewOrders.FullRowSelect = true;

        }





        private void buttonback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_AllOrders(object sender, EventArgs e)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1, lvsi2, lvsi3, lvsi4;
            listViewOrders.Items.Clear();
            listViewOrders.BeginUpdate();


            foreach (Order order in Model.OrderList)
            {
                foreach (ProductLine productLine in order.ProductLineList)
                {
                    lvi = new ListViewItem();
                    lvi.Text = order.OrderCode.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductLineCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = order.OrderDate.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.Complete.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyRequired.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyPrepared.ToString();
                    lvi.SubItems.Add(lvsi1);
                    listViewOrders.Items.Add(lvi);

                }
            }
            listViewOrders.EndUpdate();

            listViewOrders.Items[1].BackColor = Color.Yellow; // highlight a row TBD
            listViewOrders.Enabled = true;
            listViewOrders.FullRowSelect = true;

        }



        private void radioButton2_OrdersRequiringAttention(object sender, EventArgs e)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1, lvsi2, lvsi3, lvsi4;
            listViewOrders.Items.Clear();
            listViewOrders.BeginUpdate();


            foreach (Order order in Model.OrderList)
            {
                foreach (ProductLine productLine in order.ProductLineList.Where(productLine => productLine.Complete == false))
                {
                    lvi = new ListViewItem();
                    lvi.Text = order.OrderCode.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductLineCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = order.OrderDate.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.Complete.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyRequired.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyPrepared.ToString();
                    lvi.SubItems.Add(lvsi1);
                    listViewOrders.Items.Add(lvi);

                }
            }
            listViewOrders.EndUpdate();

            listViewOrders.Items[1].BackColor = Color.Yellow; // highlight a row TBD
            listViewOrders.Enabled = true;
            listViewOrders.FullRowSelect = true;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            IOrder matchOrder = Model.OrderList.FirstOrDefault(order => order.OrderCode.ToString() == textBoxOrderCode.Text.Trim());
            if (matchOrder != null)
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi1, lvsi2, lvsi3, lvsi4;
                listViewOrders.Items.Clear();
                listViewOrders.BeginUpdate();
                  foreach (ProductLine productLine in matchOrder.ProductLineList)
                  {
                    
                    lvi = new ListViewItem();
                    lvi.Text = matchOrder.OrderCode.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductLineCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = matchOrder.OrderDate.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.Complete.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.ProductCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyRequired.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.QtyPrepared.ToString();
                    lvi.SubItems.Add(lvsi1);
                    listViewOrders.Items.Add(lvi);

                }
            
            listViewOrders.EndUpdate();
            listViewOrders.Enabled = true;
            listViewOrders.FullRowSelect = true;
            textBoxOrderCode.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Order Code");
                textBoxOrderCode.Text = "";
            }
        }

    }
}

