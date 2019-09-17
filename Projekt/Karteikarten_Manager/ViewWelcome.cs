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

        public ViewWelcome()
        {
            InitializeComponent();
        }
        void IViewWelcome.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        private void MetroButtonImport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
