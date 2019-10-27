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
        string currVocListName = ""; //Enthält den Namen aktuell ausgewählter Liste
        void IModelCardManager.genXMLFromCSV(string filename, string fileoutputname)
        {
            //Returns every column from csv in an String Array
            string[] source = File.ReadAllLines(filename, Encoding.GetEncoding("iso-8859-1")); //Speichern der Werte aus der CSV in Array
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

        void IModelCardManager.createNewVocList(String name, String s1, String s2, String fileoutputname)
        {
            XElement voc = new XElement("Vokabelliste",
                                new XElement("Name", name),
                                new XElement("Sprache1", s1),
                                new XElement("Sprache2", s2)
                                );
            voc.Save(fileoutputname + ".xml");
        }

        void IModelCardManager.resetVocList()
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                IEnumerable<XElement> result = doc.Descendants("Vokabel");
                ArrayList vocList = new ArrayList();

                foreach (XElement e in result)
                {
                    e.Element("Kasten").Value = "1";
                }
                doc.Save(this.getPath());
            }
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

        void IModelCardManager.setCurrVocList(string name)
        {
            this.currVocListName = name;
        }

        string IModelCardManager.getCurrVocList()
        {
            return currVocListName;
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

        IEnumerable IModelCardManager.readVocList(String sprache) //Sprache: VocSprache1, VocSprache2
        {
            if (sprache.Equals("VocSprache1") || sprache.Equals("VocSprache2"))
            {
                String path = getPath();
                if (!path.Equals(""))
                {
                    XDocument doc = XDocument.Load(path);
                    IEnumerable<XElement> result = doc.Descendants("Vokabel");
                    ArrayList vocList = new ArrayList();

                    foreach (XElement e in result)
                    {
                        vocList.Add((string)e.Element(sprache));
                    }
                    return vocList;
                }
                else
                {
                    throw new FileNotFoundException("Fehler beim Zugriff auf die Vokabelliste");
                }
            }
            else
            {
                return new ArrayList();
            }
        }

        IEnumerable IModelCardManager.readFinishedVoc()
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                IEnumerable<XElement> result = doc.Descendants("Vokabel").Where(e => e.Element("Kasten").Value == "6");
                ArrayList vocList = new ArrayList();

                foreach (XElement e in result)
                {
                    vocList.Add((string)e.Element("VocSprache1"));
                }
                return vocList;
            }
            else
            {
                throw new FileNotFoundException("Fehler beim Zugriff auf die Vokabelliste");
            }
        }

        string getPath() //Gibt den Pfad zurück der aktuell ausgewählten XML Datei
        {
            if(File.Exists("bestand.xml"))
            {
                XDocument doc = XDocument.Load("bestand.xml");
                IEnumerable<XElement> result = doc.Descendants("Vokabelliste").Where(i => i.Element("Name").Value == currVocListName);
                foreach(XElement e in result)
                {
                    return e.Element("Path").Value + ".xml";
                }
                return "";
            }
            else
            {
                return "";
            }
        } //TODO Error wenn Liste mit selben Namen in Bestand.xml existiert und man eine löscht

        String[] IModelCardManager.getLanguages() //Gibt die beiden Sprachen in einem Array (S1, S2) zurück
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                return new String[2] {doc.Root.Element("Sprache1").Value, doc.Root.Element("Sprache2").Value };  
            }
            else
            {
                throw new FileNotFoundException("Fehler beim Zugriff auf die Vokabelliste");
            }
        }

        ArrayList[] IModelCardManager.getVoc(int kastenNr) //Gibt die Vokabeln aus einem bestimmten Kasten aus
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                ArrayList vocS1 = new ArrayList(); //Vokabeln in der ersten Sprache
                ArrayList vocS2 = new ArrayList(); //Vokablen in der zweiten Sprache

                IEnumerable<XElement> result = doc.Descendants("Vokabel").Where(x => x.Element("Kasten").Value == kastenNr.ToString());
                foreach (XElement e in result)
                {
                    vocS1.Add(e.Element("VocSprache1").Value);
                    vocS2.Add(e.Element("VocSprache2").Value);
                }
                return new ArrayList[] { vocS1, vocS2 };
            }
            return null;
        }

        void IModelCardManager.changeVocKasten(string vocS1, int kastenNr)
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                doc.Descendants("Vokabel").Where(x => x.Element("VocSprache1").Value == vocS1).First().Element("Kasten").Value = kastenNr.ToString();
                doc.Save(getPath());
            }
        }

        void IModelCardManager.deleteVoc(string vocS1)
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                doc.Descendants("Vokabel").Where(x => x.Element("VocSprache1").Value == vocS1).First().Remove();
                doc.Save(path);
            }
        }

        void IModelCardManager.addVoc(string vocS1, string vocS2)
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                doc.Root.Add(new XElement("Vokabel",
                                     new XElement("VocSprache1", vocS1),
                                     new XElement("VocSprache2", vocS2),
                                     new XElement("Kasten", "1")
                                     )
                       );
                doc.Save(path);
            }
        }

        void IModelCardManager.editVoc(string vocS1, string vocS2, string oldVocS1)
        {
            String path = getPath();
            if (!path.Equals(""))
            {
                XDocument doc = XDocument.Load(path);
                var voc = doc.Root.Elements("Vokabel").Where(e => e.Element("VocSprache1").Value == oldVocS1).Single();
                voc.Element("VocSprache1").Value = vocS1;
                voc.Element("VocSprache2").Value = vocS2;
                doc.Save(path);
            }
        }
    }
}