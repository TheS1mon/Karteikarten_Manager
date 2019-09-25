using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IModelCardManager
    {
        void genXMLFromCSV(string filename, string fileoutputname);

        void addToXMLList(string name, string sprache1, string sprache2, string path);

        void delVocList(string name);

        IEnumerable readBestandList();
    }
}
