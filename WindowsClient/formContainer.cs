using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class formContainer : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion  
        #region Constructors
        public formContainer(IModel _Model) // gets passed a reference to the model object
        {
            InitializeComponent();
            Model = _Model;
        }
        #endregion
        private void formContainer_Shown(object sender, EventArgs e)
        {
            formLogin formLgn = new formLogin(Model);
            formLgn.ShowDialog();

            //MessageBox.Show("dada" + Model.getIsManagerForCurrentUser().ToString());
            if (Model.getIsManagerForCurrentUser())
            {
                formManager form1 = new formManager(Model); // All forms get passed the formContainer and a reference to the model object. 
                this.Text = this.Text + "-Manager";
                form1.Dock = DockStyle.Fill;
                form1.Show();
            }
            else
            {
                formSales form2 = new formSales(this, Model);// All forms get passed the formContainer and a reference to the model object. 
                this.Text = this.Text + "-Sales";
                form2.Dock = DockStyle.Fill;
                form2.Show();
            }
            /*
            switch (Model.getUserTypeForCurrentuser())
            {
                case "Manager":
                    formManager form1 = new formManager(this, Model); // All forms get passed the formContainer and a reference to the model object. 
                    this.Text = this.Text + "-Manager";
                    form1.Dock = DockStyle.Fill;
                    form1.Show();
                    break;
                case "Sales":
                    formSales form2 = new formSales(this, Model);// All forms get passed the formContainer and a reference to the model object. 
                    this.Text = this.Text + "-Sales";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case "Production":
                    formOperator form3 = new formOperator(this, Model); // All forms get passed the formContainer and a reference to the model object. 
                    this.Text = this.Text + "-Production";
                    form3.Dock = DockStyle.Fill;
                    form3.Show();
                    break;
            }*/


        }
    }
}
