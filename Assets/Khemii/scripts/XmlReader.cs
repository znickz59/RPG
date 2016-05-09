using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using UnityEngine;

class XmlReader
{
    public XmlDocument LoadFile(string filename)
    {
        var document = new XmlDocument();
        document.Load("Assets/Resources/Xml/" + GlobalValues.Locale + "/" + filename + ".xml");
        return document;
    }
    public string Read(XmlDocument document, string skillName, int item)
    {
        return document.GetElementsByTagName(skillName).Item(0).ChildNodes.Item(item).InnerText;
    }
    public Quest Read(XmlDocument document, uint ID)
    {
        string title = document.GetElementsByTagName("ID" + ID.ToString()).Item(0).ChildNodes.Item(0).InnerText;
        string desc = document.GetElementsByTagName("ID" + ID.ToString()).Item(0).ChildNodes.Item(1).InnerText;
        uint next = uint.Parse(document.GetElementsByTagName("ID" + ID.ToString()).Item(0).ChildNodes.Item(2).InnerText);
        return new Quest(ID, title, desc, next);
    }
}