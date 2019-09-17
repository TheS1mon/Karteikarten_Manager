using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Karteikarten_Manager
{
    class ModelCardManager : IModelCardManager
    {
        void IModelCardManager.genXMLFromCSV(string filename, string fileoutputname)
        {
            //Returns every column from csv in an String Array
            string[] source = File.ReadAllLines(filename + ".csv"); //Speichern der Werte aus der CSV in Array
            string[] languages = source[2].Split(';'); //Speichern der beiden Sprachen
            string name = source[0].Trim(';'); //Speichern des Namens der Liste
            string[] sourceCut = new string[source.Length - 3]; //Erstellen eines Arrays nur mit Vokabeln
            Array.Copy(source, 3, sourceCut, 0, sourceCut.Length); //Belegen des Arrays sourceCut mit Werten

            //Generierung des XML Files
            XElement voc = new XElement("Vokabelliste",
                                new XElement("Name", name),
                                new XElement("Sprache1", languages[0]),
                                new XElement("Sprache2", languages[1]),
            from str in sourceCut
            let fields = str.Split(';')
                         select new XElement("Vokabel",
                                new XElement("VocSprache1", fields[0]),
                                new XElement("VocSprache2", fields[1]),
                                new XElement("Kasten", "1")
                                            )
                                       );
            voc.Save(fileoutputname + ".xml");
        }
    }
}
