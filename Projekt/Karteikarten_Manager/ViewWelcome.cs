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
    public partial class ViewWelcome : MetroFramework.Forms.MetroForm, IViewWelcome
    {
        private IControllerCardManager controllerCardManager;
        private IViewMenu viewMenu = new ViewMenu();
        private IViewImport viewImport;

        public ViewWelcome()
        {
            InitializeComponent();
        }

        //Reference Settings
        void IViewWelcome.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        void IViewWelcome.setReference(IViewMenu viewMenu)
        {
            this.viewMenu = viewMenu;
        }

        void IViewWelcome.setReference(IViewImport viewImport)
        {
            this.viewImport = viewImport;
        }

        //Custom Methods
        void IViewWelcome.showForm()
        {
            this.Show();
            this.CenterToScreen();
        }

        void clearComboBox()
        {
            metroComboBoxSelection.Items.Clear();

            foreach (string name in controllerCardManager.getBestandsListe())
            {
                metroComboBoxSelection.Items.Add(name);
            }
        }

        //Eventhandler
        private void MetroButtonImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewImport.showForm();
        }

        private void MetroButtonStart_Click(object sender, EventArgs e)
        {
            if(this.metroComboBoxSelection.SelectedItem != null)
            {
                this.Hide();
                controllerCardManager.setCurrVocList(metroComboBoxSelection.SelectedItem.ToString());
                viewMenu.showForm();
            }
            else
            {
                MessageBox.Show("Bitte Kartenbestand auswählen");
            }
            
        }

        private void MetroComboBoxSelection_MouseDown(object sender, EventArgs e)
        {
            this.clearComboBox(); 
        }

        private void MetroButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                controllerCardManager.delVocList(metroComboBoxSelection.SelectedItem.ToString());
            }
            catch (Exception) //Nullpointer when selected nothing
            {

            }
            this.clearComboBox();
        }

        private void MetroButtonReset_Click(object sender, EventArgs e)
        {
            controllerCardManager.resetVocList();
        }
    }
}
