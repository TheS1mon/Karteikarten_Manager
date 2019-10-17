﻿using System;
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

        void IControllerCardManager.addXMLToListControl(String name, String sprache1, String sprache2, String path)
        {
                modelCardManager.addToXMLList(name, sprache1, sprache2, path);
        }

        void IControllerCardManager.delVocList(string name)
        {
            modelCardManager.delVocList(name);
        }

        void IControllerCardManager.setCurrVocList(string name)
        {
            modelCardManager.setCurrVocList(name);
        }

        string IControllerCardManager.getCurrVocList()
        {
            return modelCardManager.getCurrVocList();
        }

        IEnumerable IControllerCardManager.getBestandsListe()
        {
            return modelCardManager.readBestandList();
        }

        String[] IControllerCardManager.getLanguages()
        {
            return modelCardManager.getLanguages();
        }
    }
}