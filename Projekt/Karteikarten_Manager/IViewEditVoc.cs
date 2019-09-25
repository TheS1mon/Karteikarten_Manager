using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IViewEditVoc
    {
        void setController(IControllerCardManager controllerCardManager);

        void setReference(IViewMenu viewMenu);

        void showForm();
    }
}
