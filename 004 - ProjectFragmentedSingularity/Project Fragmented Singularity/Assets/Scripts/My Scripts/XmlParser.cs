using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XmlParser {

    public XmlParser()
    {
        TextAsset testXMLFile = Resources.Load<TextAsset>("test");
        parseFile(testXMLFile);
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () { 

	}

    public List<string> parseFile(TextAsset textAsset)
    {
        //Load the xml file containing all items.
        XmlDocument allItemsFileXml = new XmlDocument();
        allItemsFileXml.Load(textAsset.text);

        //Should be a list of all items in xml format
        XmlNodeList allXmlItems = allItemsFileXml.DocumentElement.ChildNodes;

        //Create and fill array of items
        /*Item[] allItems = new Item[allXmlItems.Count];
        for (int i = 0; i < allXmlItems.Count; i++)
        {
            allItems[i] = new Item(allXmlItems[i].ChildNodes[0].InnerText, int.Parse(allXmlItems[i].ChildNodes[1].InnerText));
        }*/

        return new List<string>();
    }
}
