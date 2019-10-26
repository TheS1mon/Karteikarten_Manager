using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IControllerCardManager
    {
        void procressCSV(string filename, string fileoutputname);

        void addXMLToListControl(String name, String sprache1, String sprache2, String path);

        void delVocList(string name);

        void setCurrVocList(string name);

        string getCurrVocList();

        IEnumerable getBestandsListe();

        IEnumerable getVocList(String sprache);

        String[] getLanguages();

        String[] getRandomVoc(int kastenNr);

        void changeVocKasten(String vocS1, int vocKasten);

        void deleteVoc(String vocS1);

        void addVoc(String vocS1, String vocS2);

        void editVoc(String vocS1, String vocS2, String oldVocS1);
    }
}
