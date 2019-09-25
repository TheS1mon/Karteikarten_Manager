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
            IViewWelcome viewWelcome = new ViewWelcome();
            IViewImport viewImport = new ViewImport();
            IViewMenu viewMenu = new ViewMenu();
            IViewEditVoc viewEditVoc = new ViewEditVoc();
            viewCardManager.setController(controllerCardManager);
            viewWelcome.setController(controllerCardManager);
            viewImport.setController(controllerCardManager);
            viewMenu.setController(controllerCardManager);
            viewEditVoc.setController(controllerCardManager);

            //Übergabe der einzellnen Views zum gegenseitigen Aufrufen
            viewWelcome.setReference(viewMenu);
            viewWelcome.setReference(viewImport);
            viewImport.setReference(viewWelcome);
            viewMenu.setReference(viewCardManager);
            viewMenu.setReference(viewWelcome);
            viewMenu.setReference(viewEditVoc);
            viewCardManager.setReference(viewMenu);
            viewEditVoc.setReference(viewMenu);

            Application.Run((ViewWelcome)viewWelcome);
        }
    }
}
