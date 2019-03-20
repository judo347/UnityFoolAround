using Assets.Scripts.My_Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XmlParser {

	Item[] allItems;

    public XmlParser()
    {
		allItems = loadAllIngameItems(Resources.Load<TextAsset>("allItems"));
    }

    public List<string> parseFile(TextAsset textAsset)
    {
        //Load the xml file containing all items.
        XmlDocument allItemsFileXml = new XmlDocument();
        allItemsFileXml.LoadXml(textAsset.text);

        //Should be a list of all items in xml format
        XmlNodeList allXmlItems = allItemsFileXml.DocumentElement.ChildNodes;

		//Debug.Log(allItemsFileXml.ToString());

        //Create and fill array of items
        /*Item[] allItems = new Item[allXmlItems.Count];
        for (int i = 0; i < allXmlItems.Count; i++)
        {
            allItems[i] = new Item(allXmlItems[i].ChildNodes[0].InnerText, int.Parse(allXmlItems[i].ChildNodes[1].InnerText));
        }*/

        return new List<string>();
    }

	/** Loads all items from the xml file and returns an item array with all items. */
	private Item[] loadAllIngameItems(TextAsset textAsset)
	{
		//Load the xml file containing all items.
		XmlDocument allItemsFileXml = new XmlDocument();
		allItemsFileXml.LoadXml(textAsset.text);

		//Should be a list of all items in xml format
		XmlNodeList allXmlItems = allItemsFileXml.DocumentElement.ChildNodes;
		//Console.WriteLine(allXmlItems.Count); //Number of items/elements in file.

		//Create and fill array of items
		Item[] allItems = new Item[allXmlItems.Count];
		for (int i = 0; i < allXmlItems.Count; i++)
		{
			allItems[i] = new Item(allXmlItems[i].ChildNodes[0].InnerText, int.Parse(allXmlItems[i].ChildNodes[1].InnerText));
		}

		/* MAY BE DELETED: Used for testing
		foreach (XmlNode node in allXmlItems)
		{
			Console.Write("Item Name: " + node.ChildNodes[0].InnerText);
			Console.WriteLine(" ID: " + node.ChildNodes[1].InnerText);
		}*/

		/* MAY BE DELETED: Used for testing
		foreach (Item item in allItems)
		{
			Console.Write(item.id);
			Console.WriteLine(item.name);
		}*/

		return allItems;
	}
}
