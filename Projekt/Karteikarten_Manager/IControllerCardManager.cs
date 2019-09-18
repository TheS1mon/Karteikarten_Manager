using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IControllerCardManager
    {
        void procressCSV(string filename, string fileoutputname);

        int addXMLToListControl(String name, String sprache1, String sprache2, String path);
    }
}
