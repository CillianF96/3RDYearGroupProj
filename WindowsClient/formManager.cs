using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitITDone_Forms;

namespace ProductTracking
{
    public partial class formManager : Form
    {
        #region Instance Attributes
        private formContainer fc;
        private IModel Model;
        #endregion

        #region Constructors
        public formManager(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }
        #endregion


       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            formAddUser form = new formAddUser(Model);
            form.Dock = DockStyle.Fill;
            form.Show();
         }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            formDeleteUser form = new formDeleteUser(Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            FormDataSelector fds = new FormDataSelector(Model);
            fds.Dock = DockStyle.Fill;
            fds.Show();

        }
    }
}
