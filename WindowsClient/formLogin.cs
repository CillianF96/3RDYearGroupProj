using BusinessLayer;
using System;
using System.Windows.Forms;


namespace ProductTracking
{

    public partial class formLogin : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        #region Constructors
        public formLogin(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            bool validUser = Model.login(textBoxName.Text, textBoxPassword.Text);


            if (validUser)
            {
                this.Close();

            }


            else
            {
                MessageBox.Show("Invalid name or password");
                textBoxName.Text = "";
                textBoxPassword.Text = "";
                textBoxName.Select();
            }

        }
    }
}
