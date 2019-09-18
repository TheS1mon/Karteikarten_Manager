using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteikarten_Manager
{
    public partial class ViewImport : MetroFramework.Forms.MetroForm, IViewImport
    {
        private IControllerCardManager controllerCardManager;
        private IViewWelcome viewWelcome;

        public ViewImport()
        {
            InitializeComponent();
        }

        //Reference Settings
        void IViewImport.setController(IControllerCardManager controller) 
        {
            controllerCardManager = controller;
        }

        void IViewImport.setReference(IViewWelcome viewWelcome)
        {
            this.viewWelcome = viewWelcome;
        }

        //Custom Methods
        void IViewImport.showForm()
        {
            this.Show();
            this.CenterToScreen();
        }

        //Eventhandler
        private void MetroButtonOpenDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCSV.ShowDialog();
            if (result == DialogResult.OK)
            {
                metroTextBoxPath.Text = openFileDialogCSV.FileName;
            }
        }

        private void ViewImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            viewWelcome.showForm();
        }
    }
}
