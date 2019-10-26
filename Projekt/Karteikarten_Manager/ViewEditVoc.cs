using System;
using System.Collections;
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
        private String selectedLanguage = "S1";
        ArrayList vocListS1;
        ArrayList vocListS2;

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
            this.Initialize();
            this.CenterToScreen();
            String[] languages = controllerCardManager.getLanguages();
            labelSprache1.Text = languages[0] + ":";
            labelSprache1_1.Text = languages[0] + ":";
            labelSprache2.Text = languages[1] + ":";
            labelSprache2_1.Text = languages[1] + ":";
        }

        void Initialize()
        {
            listBoxVoc.Items.Clear();
            metroTextBoxVocInputS1.Text = "";
            metroTextBoxVocInputS2.Text = "";
            vocListS1 = (ArrayList)controllerCardManager.getVocList("VocSprache1");
            vocListS2 = (ArrayList)controllerCardManager.getVocList("VocSprache2");
            if (selectedLanguage.Equals("S1"))
            {
                foreach (String str in vocListS1)
                {
                    listBoxVoc.Items.Add(str);
                }
            }
            else
            {
                foreach (String str in vocListS2)
                {
                    listBoxVoc.Items.Add(str);
                }
            }
            if(listBoxVoc.Items.Count == 0)
            {
                listBoxVoc.Enabled = false;
                metroTabControl1.SelectedTab = metroTabPage1;
            }
            else
            {
                listBoxVoc.Enabled = true;
                listBoxVoc.SelectedIndex = 0;
            }
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

        private void ListBoxVoc_SelectedIndexChanged(object sender, EventArgs e) //Loads the Voc when the selected-item Index changes
        {
            if(listBoxVoc.SelectedIndex != 0)
            {
                metroTabControl1.SelectedTab = metroTabPage2;
            }
            metroTextBoxEditVoc1.Text = vocListS1[listBoxVoc.SelectedIndex].ToString();
            metroTextBoxEditVoc2.Text = vocListS2[listBoxVoc.SelectedIndex].ToString();
        }

        private void MetroButtonChangeLanguage_Click(object sender, EventArgs e)
        {
            if(this.selectedLanguage.Equals("S1"))
            {
                this.selectedLanguage = "S2";
            }
            else
            {
                this.selectedLanguage = "S1";
            }
            this.Initialize();
        }

        private void MetroButtonDelVoc_Click(object sender, EventArgs e)
        {
            controllerCardManager.deleteVoc(vocListS1[listBoxVoc.SelectedIndex].ToString());
            this.Initialize();
        }

        private void MetroButtonAddVoc_Click(object sender, EventArgs e)
        {
            controllerCardManager.addVoc(metroTextBoxVocInputS1.Text, metroTextBoxVocInputS2.Text);
            this.Initialize();
        }

        private void MetroButtonChangeVoc_Click(object sender, EventArgs e)
        {
            try
            {
                controllerCardManager.editVoc(metroTextBoxEditVoc1.Text, metroTextBoxEditVoc2.Text, vocListS1[listBoxVoc.SelectedIndex].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Interner Fehler: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Initialize();
        }
    }
}
