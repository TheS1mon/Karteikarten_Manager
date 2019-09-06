using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteikarten_Manager
{
    static class Karteikarten_Manager
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MVC-Setup
            IModelCardManager modelCardManager = new ModelCardManager();
            IControllerCardManager controllerCardManager = new ControllerCardManager(modelCardManager);
            IViewCardManager viewCardManager = new ViewCardManager();
            viewCardManager.setController(controllerCardManager);

            Application.Run((ViewCardManager)viewCardManager);
        }
    }
}
