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
    public partial class ViewMenu : MetroFramework.Forms.MetroForm, IViewMenu
    {
        private IControllerCardManager controllerCardManager;
        private IViewWelcome viewWelcome;
        private IViewCardManager viewCardManager;
        private IViewEditVoc viewEditVoc;

        public ViewMenu()
        {
            InitializeComponent();
        }

        //Reference Settings
        void IViewMenu.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        void IViewMenu.setReference(IViewWelcome viewWelcome)
        {
            this.viewWelcome = viewWelcome;
        }

        void IViewMenu.setReference(IViewCardManager viewCardManager)
        {
            this.viewCardManager = viewCardManager;
        }

        void IViewMenu.setReference(IViewEditVoc viewEditVoc)
        {
            this.viewEditVoc = viewEditVoc;
        }

        //Custom Methods
        void IViewMenu.showForm()
        {
            this.Show();
            this.CenterToScreen();
        }

        //Eventhandler
        private void ButtonBackToWelcome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            viewWelcome.showForm();
        }

        private void ButtonVocMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewCardManager.showForm();
        }

        private void ButtonEditMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewEditVoc.showForm();
        }
    }
}
