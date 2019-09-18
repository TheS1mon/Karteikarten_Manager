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
    public partial class ViewCardManager : MetroFramework.Forms.MetroForm, IViewCardManager
    {
        private IControllerCardManager controllerCardManager;
        private IViewMenu viewMenu;

        public ViewCardManager()
        {
            InitializeComponent();  
        }

        //Reference Settings
        void IViewCardManager.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        void IViewCardManager.setReference(IViewMenu viewMenu)
        {
            this.viewMenu = viewMenu;
        }

        //Custom Methods
        void IViewCardManager.showForm()
        {
            this.Show();
            this.CenterToScreen();
        }

        //Eventhandler
        private void MetroButtonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewCardManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            viewMenu.showForm();
        }
    }
}
