using BusinessLayer;
using System.Windows.Forms;

namespace ConsolatioWireFrames
{
    public partial class formDiningMain : Form
    {
        IModel Model;
        public formDiningMain(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void btnDiningMainClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
