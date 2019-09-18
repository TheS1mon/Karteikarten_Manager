using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IViewMenu
    {
        void setController(IControllerCardManager controllerCardManager);

        void setReference(IViewWelcome viewWelcome);

        void setReference(IViewCardManager viewCardManager);

        void showForm();
    }
}
