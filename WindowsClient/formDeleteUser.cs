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
    public partial class formDeleteUser : Form
    {
        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion 

       #region Constructors
        public formDeleteUser(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;

        }
        #endregion

        private void PopulateDataSource()
        {
            userBindingSource.DataSource = Model.UserList;
            dgvUserList.Columns[0].ReadOnly = true;
            DataGridViewButtonColumn colSaveButton = new DataGridViewButtonColumn()
            {
                Name = "btnDelete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true //dont forget this line
            };
            dgvUserList.Columns.Add(colSaveButton);
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formDeleteUser_Load(object sender, EventArgs e)
        {
            PopulateDataSource();
        
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Delete " + dgvUserList.Rows[e.RowIndex].Cells[1].Value.ToString() + "? ", "Delete User?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                foreach (User user in Model.UserList)
                {
                    if (user.UserID == (int)dgvUserList.Rows[e.RowIndex].Cells[0].Value)
                    {

                        user.PrintUserDetails();
                        Model.deleteUser(user);
                        dgvUserList.DataSource = Model.UserList;
                        //MessageBox.Show(String.Join(" ", Model.UserList.Select(x => x.Username)));
                        dgvUserList.Update();
                        dgvUserList.Refresh();
                        break;
                    }
                }
            }
        }
    }
}
