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
        document.Load("Assets/Resources/Xml/ENG/" + filename + ".xml");
        return document;
    }
    public string Read(XmlDocument document, string skillName, int item)
    {
        return document.GetElementsByTagName(skillName).Item(0).ChildNodes.Item(item).InnerText;
    }
}