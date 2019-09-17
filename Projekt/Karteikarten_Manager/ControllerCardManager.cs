using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    class ControllerCardManager : IControllerCardManager
    {
        private IModelCardManager modelCardManager;

        public ControllerCardManager(IModelCardManager model)
        {
            modelCardManager = model;
        }


        void IControllerCardManager.procressCSV(string filename, string fileoutputname)
        {
            modelCardManager.genXMLFromCSV(filename, fileoutputname);
        }
    }
}