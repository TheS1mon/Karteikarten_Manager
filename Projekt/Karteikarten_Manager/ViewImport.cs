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
    //TODO Bugfixing, nicht mehrere Vokabellisten mit gleichem Namen abspeichern können
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

        string buildTitle()
        {
            return metroTextBoxName.Text.Replace(" ", "").ToLower() + "_" + metroTextBoxS1.Text.Replace(" ", "").ToLower() + "_" + metroTextBoxS2.Text.Replace(" ", "").ToLower();
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
            metroTextBoxName.Text = "";
            metroTextBoxPath.Text = "";
            metroTextBoxS1.Text = "";
            metroTextBoxS2.Text = "";
            this.Hide();
            viewWelcome.showForm();
        }

        private void MetroButtonImport_Click(object sender, EventArgs e)
        {
            
                if (!metroTextBoxName.Text.Equals("") && !metroTextBoxS1.Text.Equals("") && !metroTextBoxS2.Text.Equals(""))
                {
                    if (!metroCheckBoxCSV.Checked)
                    {
                        try
                        {
                        if (!metroTextBoxPath.Text.Equals(""))
                        {
                            controllerCardManager.procressCSV(metroTextBoxPath.Text, this.buildTitle());
                            controllerCardManager.addXMLToListControl(metroTextBoxName.Text, metroTextBoxS1.Text, metroTextBoxS2.Text, this.buildTitle());

                            MessageBox.Show("Erfolgreich");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bitte CSV-Datei auswählen");
                        }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ein Fehler ist aufgetreten, vielleicht ist die CSV Datei nicht richtig formatiert.");
                        }
                    }
                    else
                    {
                        controllerCardManager.createNewVocList(metroTextBoxName.Text, metroTextBoxS1.Text, metroTextBoxS2.Text, this.buildTitle());
                        controllerCardManager.addXMLToListControl(metroTextBoxName.Text, metroTextBoxS1.Text, metroTextBoxS2.Text, this.buildTitle());
                        MessageBox.Show("Erfolgreich");
                        this.Close();
                }
                }
                else
                {
                    MessageBox.Show("Bitte alle Felder ausfüllen");
                }
            
        }

        private void MetroButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
