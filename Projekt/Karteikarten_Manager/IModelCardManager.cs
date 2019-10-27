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

        void createNewVocList(String name, String s1, String s2, String fileoutputname);

        void resetVocList();

        void addToXMLList(string name, string sprache1, string sprache2, string path);

        void delVocList(string name);

        void setCurrVocList(string name);

        string getCurrVocList();

        IEnumerable readBestandList();

        IEnumerable readVocList(String sprache);

        IEnumerable readFinishedVoc();

        String[] getLanguages();

        ArrayList[] getVoc(int kastenNr);

        void changeVocKasten(String vocS1, int kastenNr);

        void deleteVoc(String vocS1);

        void addVoc(String vocS1, String vocS2);

        void editVoc(String vocS1, String vocS2, String oldVocS1);
    }
}
