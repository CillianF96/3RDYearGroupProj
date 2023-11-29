using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using BusinessEntities;

namespace ProductTracking
{
    public partial class formAllocatePreparedProduct 
    {
        private IModel Model;
        formContainer fc;
        public formAllocatePreparedProduct(formContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
            buttonFind.Enabled = false;
            buttonAddProduct.Enabled = false;
            textBoxAmount.Enabled = false;

            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "ProductLineCodeCode";
            colHead.Width = listViewProductLines.Width / 5;
            listViewProductLines.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "OrderCode";
            colHead.Width = listViewProductLines.Width /5;
            listViewProductLines.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "ProductCode";
            listViewProductLines.Columns.Add(colHead);
            colHead.Width = listViewProductLines.Width / 5;
            colHead = new ColumnHeader();
            colHead.Text = "QtyOrdered";
            listViewProductLines.Columns.Add(colHead);
            colHead.Width = listViewProductLines.Width / 5;

            colHead = new ColumnHeader();
            colHead.Text = "QtyPrepared";
            listViewProductLines.Columns.Add(colHead);
            colHead.Width = listViewProductLines.Width / 5;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1, lvsi2, lvsi3, lvsi4;
            listViewProductLines.Items.Clear();
            listViewProductLines.BeginUpdate();

             foreach (ProductLine productLine in Model.ProductLineList)
            {
                if (productLine.ProductCode.Trim() == textBoxProductCode.Text.Trim())
                {
                    lvi = new ListViewItem();
                    lvi.Text = productLine.ProductLineCode.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = productLine.OrderCode.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi2 = new ListViewItem.ListViewSubItem();
                    lvsi2.Text = productLine.ProductCode.ToString();
                    lvi.SubItems.Add(lvsi2);

                    lvsi3 = new ListViewItem.ListViewSubItem();
                    lvsi3.Text = productLine.QtyRequired.ToString();
                    lvi.SubItems.Add(lvsi3);

                    lvsi4 = new ListViewItem.ListViewSubItem();
                    lvsi4.Text = productLine.QtyPrepared.ToString();
                    lvi.SubItems.Add(lvsi4);

                    listViewProductLines.Items.Add(lvi);
                }
            }
            listViewProductLines.EndUpdate();
            listViewProductLines.Enabled = true;
            listViewProductLines.FullRowSelect = true;

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt16(listViewProductLines.SelectedItems[0].SubItems[4].Text);
            amount += Convert.ToInt16(textBoxAmount.Text.ToString());
            if (amount > Convert.ToInt16(listViewProductLines.SelectedItems[0].SubItems[3].Text))
            {
                MessageBox.Show("Too much product being allocated");
                textBoxAmount.Clear();
                return;
            }

            listViewProductLines.SelectedItems[0].SubItems[4].Text = amount.ToString();
            
            foreach (ProductLine productLine in Model.ProductLineList)
            {
                if (productLine.ProductLineCode == Convert.ToInt16(listViewProductLines.SelectedItems[0].SubItems[0].Text.ToString()) && productLine.OrderCode == Convert.ToInt16(listViewProductLines.SelectedItems[0].SubItems[1].Text.ToString()))
                    // looking for a ProductLine which matches on ProductLineCode and OrderClone
                {
                    productLine.QtyPrepared = amount;
                    if (productLine.QtyPrepared == productLine.QtyRequired)
                    {
                        productLine.Complete = true;  // mark the line item as complete
                    }
                    Model.updateProductLine(productLine);
                break;
                }
            }
        }
            

        private void textBoxProductCode_TextChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }

        private void listViewProductLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAmount.Enabled = true;
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            buttonAddProduct.Enabled = true;
        }

   

   
    }
}
