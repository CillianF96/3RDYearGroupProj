using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class PrintVoucher : Form
    {
        IModel Model;

        public PrintVoucher(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void PrintVoucher_Load(object sender, EventArgs e)
        {
            DisplayVoucher();
        }

        public void DisplayVoucher()
        {
            Model.PopulateVoucher();
            dgvPrintVoucher.DataSource = new BindingList<IVoucher>(Model.VoucherList.ToList());
        }

        private void btnPrintVoucherClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                MessageBox.Show("Please enter a name to search for");
            }
            else
            {
                string searchName = txtBoxName.Text;


                List<DataGridViewRow> matchingRows = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvPrintVoucher.Rows)
                {
                    bool matchFound = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchName))
                        {
                            matchFound = true;
                            break;
                        }
                    }

                    if (matchFound)
                    {
                        matchingRows.Add(row);
                    }
                }
                if (matchingRows.Count > 0)
                {
                    dgvPrintVoucher.ClearSelection();

                    foreach (DataGridViewRow row in matchingRows)
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Voucher selectedVoucher = (Voucher)dgvPrintVoucher.CurrentRow.DataBoundItem;
            //e.Graphics.DrawString(selectedVoucher.PrintVoucherDetails(), new Font("Times New Romen", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 100));

            Voucher selectedVoucher = (Voucher)dgvPrintVoucher.CurrentRow.DataBoundItem;

            // Set the initial Y-coordinate
            float yCoordinate = 100;

            // Define the font and other properties
            Font font = new Font("Times New Roman", 16, FontStyle.Bold);
            Brush brush = Brushes.Black;

            // Loop through each line of the voucher details
            foreach (string line in selectedVoucher.PrintVoucherDetails().Split('\n'))
            {
                // Draw the current line
                e.Graphics.DrawString(line, font, brush, new PointF(100, yCoordinate));

                // Increase the Y-coordinate for the next line with a gap
                yCoordinate += font.GetHeight() + 5; // You can adjust the gap by changing the value (e.g., 5)
            }



        }

        private void BtnPrintVoucher_Click(object sender, EventArgs e)
        {
            PrintDialog printDocument = new PrintDialog();

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
