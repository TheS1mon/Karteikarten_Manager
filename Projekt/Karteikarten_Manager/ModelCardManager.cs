using System;
using System.Collections;
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
            string[] source = File.ReadAllLines(filename); //Speichern der Werte aus der CSV in Array
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

        void IModelCardManager.addToXMLList(string name, string sprache1, string sprache2, string path)
        {
            if(File.Exists("bestand.xml"))
            {
                XDocument bestand = XDocument.Load("bestand.xml");

                bestand.Element("Vokabeldateien").Add(
                                      new XElement("Vokabelliste",
                                            new XElement("Name", name),
                                            new XElement("Sprache1", sprache1),
                                            new XElement("Sprache2", sprache2),
                                            new XElement("Path", path)));
                bestand.Save("bestand.xml");
            }
            else
            {
                XElement bestand = new XElement("Vokabeldateien",
                                       new XElement("Vokabelliste",
                                            new XElement("Name", name),
                                            new XElement("Sprache1", sprache1),
                                            new XElement("Sprache2", sprache2),
                                            new XElement("Path", path)));
                bestand.Save("bestand.xml");
            }
        }

        void IModelCardManager.delVocList(string name)
        {
            if (File.Exists("bestand.xml"))
            {
                XDocument doc = XDocument.Load("bestand.xml");
                string path = doc.Root.Elements("Vokabelliste").Where(item => item.Element("Name").Value == name).FirstOrDefault().Element("Path").Value.ToString();
                doc.Root.Elements("Vokabelliste").Where(item => item.Element("Name").Value == name).FirstOrDefault().Remove();

                doc.Save("bestand.xml");

                if (File.Exists(path + ".xml"))
                {
                    File.Delete(path + ".xml");
                }
            }
        }

        IEnumerable IModelCardManager.readBestandList()
        {
            if (File.Exists("bestand.xml"))
            {
                XDocument doc = XDocument.Load("bestand.xml");
                IEnumerable<XElement> result = doc.Descendants("Vokabelliste");
                ArrayList nameList = new ArrayList();

                foreach (XElement e in result)
                {

                    nameList.Add((string)e.Element("Name"));
                }
                return nameList;
            }
            return new ArrayList();
        }
    }
}
