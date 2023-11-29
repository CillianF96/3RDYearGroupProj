using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;

namespace ProductTracking
{
    public partial class FoodMenuForm : Form
    {
        IModel model;
        public FoodMenuForm(IModel _model)
        {
            InitializeComponent();
        }

        private void pdfViewer1_Click(object sender, EventArgs e)
        {

        }

        private void FoodMenuForm_Load(object sender, EventArgs e)
        {
            string pdfDoc = @"..\..\Resources\FoodMenu.pdf";
            try
            {
                if (File.Exists(pdfDoc))
                {
                    this.pdfViewer1.LoadFromFile(pdfDoc);
                }
                else
                {
                    Console.WriteLine("PDF file not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading PDF file: " + ex.Message);
            }
        }

    }
}
