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

        String[] IControllerCardManager.getRandomVoc(int kastenNr)
        {
            ArrayList[] tmp = modelCardManager.getVoc(kastenNr);
            String[] s1 = (string[])tmp[0].ToArray(typeof(string));
            String[] s2 = (string[])tmp[1].ToArray(typeof(string));
            Random randy = new Random();
            if(s1.Length - 1 <= 0) //If only one Voc there would be an error
            {
                return new string[] { s1[0], s2[0] };
            }
            else
            {
                int vocNb = randy.Next(0, s1.Length - 1); //Generates a random number with maxSize of the voc's count
                return new string[] { s1[vocNb], s2[vocNb] };
            }
        }

        void IControllerCardManager.changeVocKasten(string vocS1, int vocKasten)
        {
            modelCardManager.changeVocKasten(vocS1, vocKasten);
        }

        void IControllerCardManager.deleteVoc(string vocS1)
        {
            modelCardManager.deleteVoc(vocS1);
        }
    }
}