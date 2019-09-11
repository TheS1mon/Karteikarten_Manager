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
    public partial class ViewCardManager : Form, IViewCardManager
    {
        private IControllerCardManager controllerCardManager;

        public ViewCardManager()
        {
            InitializeComponent();  
        }

        void IViewCardManager.setController(IControllerCardManager controller)
        {
            controllerCardManager = controller;
        }

        private void ButtonMultiFunc_Click(object sender, EventArgs e)
        {
            controllerCardManager.procressCSV("test");
        }
    }
}
