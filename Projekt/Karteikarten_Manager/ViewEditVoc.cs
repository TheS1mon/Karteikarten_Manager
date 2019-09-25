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
    public partial class ViewEditVoc : MetroFramework.Forms.MetroForm, IViewEditVoc
    {
        private IControllerCardManager controllerCardManager;
        private IViewMenu viewMenu;

        public ViewEditVoc()
        {
            InitializeComponent();
        }

        //Reference Settings
        void IViewEditVoc.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        void IViewEditVoc.setReference(IViewMenu viewMenu)
        {
            this.viewMenu = viewMenu;
        }

        //Custom Methods
        void IViewEditVoc.showForm()
        {
            this.Show();
            this.CenterToScreen();
        }

        //Eventhandler
        private void ViewEditVoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            viewMenu.showForm();
        }

        private void MetroButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
