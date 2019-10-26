using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Karteikarten_Manager
{
    public partial class ViewCardManager : MetroFramework.Forms.MetroForm, IViewCardManager
    {
        private IControllerCardManager controllerCardManager;
        private IViewMenu viewMenu;

        private String correctVoc = ""; //Contains the Voc required for Correction
        private String statusLabelText = ""; //Contains the Text for the Status Label

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

        void IViewCardManager.initialize()
        {
            labelBestand.Text = controllerCardManager.getCurrVocList();
            String[] languages = controllerCardManager.getLanguages();
            labelSprache1.Text = languages[1];
            labelSprache2.Text = languages[0];
            metroLabelStatus.Text = "Warte auf Eingabe..";
            this.loadNextVoc();
        }

        private void loadNextVoc()
        {
            try
            {
                String[] voc = controllerCardManager.getRandomVoc(Int32.Parse(labelKasten.Text));
                metroTextBoxOutput.Text = voc[0];
                correctVoc = voc[1];
                metroTextBoxVocInput.Text = "";
                statusLabelText = "Warte auf Eingabe..";
            }
            catch (Exception)
            {
                metroLabelStatus.Text = "Keine Vokabeln hier";
                statusLabelText = "Keine Vokabeln hier";
            }
        }

        private void timeStatusLabelandColor(String firstText, int sek, MetroFramework.MetroColorStyle color) //Changes the Text of the Status Label and the theme colour for a special ammount of time
        {
            metroLabelStatus.Text = firstText;
            this.Style = color;
            metroButtonCheck.Enabled = false;
            var t = new Timer();
            t.Interval = sek * 1000;
            t.Tick += (s, e) =>
            {
                metroLabelStatus.Text = statusLabelText;
                this.Style = MetroFramework.MetroColorStyle.Lime;
                metroButtonCheck.Enabled = true;
                t.Stop();
            };
            t.Start();
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

        private void MetroButtonNextBox_Click(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(labelKasten.Text);
            if(tmp < 6)
            {
                labelKasten.Text = (tmp + 1).ToString();
                metroTextBoxVocInput.Text = "";
                metroTextBoxOutput.Text = "";
                metroLabelStatus.Text = "Warte auf Eingabe..";
                this.loadNextVoc();
            }
        }

        private void MetroButtonPreBox_Click(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(labelKasten.Text);
            if (tmp > 1)
            {
                labelKasten.Text = (tmp - 1).ToString();
                metroTextBoxVocInput.Text = "";
                metroTextBoxOutput.Text = "";
                metroLabelStatus.Text = "Warte auf Eingabe..";
                this.loadNextVoc();
            }
        }

        private void MetroButtonCheck_Click(object sender, EventArgs e)
        {
            if(metroTextBoxVocInput.Text.Equals(correctVoc))
            {
                this.timeStatusLabelandColor("Richtig!", 3, MetroFramework.MetroColorStyle.Green);
                if (labelKasten.Text.Equals("6"))
                {
                    controllerCardManager.deleteVoc(metroTextBoxOutput.Text);
                }
                else
                {
                    controllerCardManager.changeVocKasten(metroTextBoxOutput.Text, Int32.Parse(labelKasten.Text) + 1);
                }
                metroTextBoxVocInput.Text = "";
                metroTextBoxOutput.Text = "";
                this.loadNextVoc();
            }
            else
            {
                this.timeStatusLabelandColor("Falsch: " + correctVoc, 3, MetroFramework.MetroColorStyle.Red);
                controllerCardManager.changeVocKasten(metroTextBoxOutput.Text, 1);
                metroTextBoxVocInput.Text = "";
                metroTextBoxOutput.Text = "";
                this.loadNextVoc();
            }
        }
    }
}
