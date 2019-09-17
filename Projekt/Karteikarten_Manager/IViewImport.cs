using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IViewImport
    {
        void setController(IControllerCardManager controllerCardManager);
    }
}
