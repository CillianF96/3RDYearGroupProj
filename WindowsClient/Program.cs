using BusinessLayer;
using DataAccessLayer;
using GitITDone_Forms;
using System;
using System.Windows.Forms;


namespace ProductTracking
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDataLayer _Datalayer = DataLayer.GetInstance();  // DataLayer object is a singleton, only 1 instance allowed. With Songleton pattern use GetInstance() method to create it.
            IModel _Model = Model.GetInstance(_Datalayer); // Model object is a singleton, only 1 instance allowed. With Songleton pattern use GetInstance() method to create it.

            Application.Run(new StaffMain(_Model));  // formContainer is passed a reference to the model which it stores. Any other forms which are created get passed the reference to the model object which the store and pass on etc. 
            // Make sure any form you create gets passed a reference to the model object. 

            //work

        }
    }
}
