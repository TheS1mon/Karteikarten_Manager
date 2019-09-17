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

        public ViewImport()
        {
            InitializeComponent();
        }

        void IViewImport.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        private void MetroButtonOpenDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCSV.ShowDialog();
            if (result == DialogResult.OK)
            {
                metroTextBoxPath.Text = openFileDialogCSV.FileName;
            }
        }
    }
}
