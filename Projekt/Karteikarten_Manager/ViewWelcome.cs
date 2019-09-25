﻿using System;
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

        //Eventhandler
        private void MetroButtonImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewImport.showForm();
        }

        private void MetroButtonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMenu.showForm();
        }

        private void MetroComboBoxSelection_MouseDown(object sender, EventArgs e)
        {
            metroComboBoxSelection.Items.Clear();

            foreach(string name in controllerCardManager.getBestandsListe())
            {
                metroComboBoxSelection.Items.Add(name);
            }
                
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
            
        }
    }
}
