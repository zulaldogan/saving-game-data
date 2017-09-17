using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLManager : MonoBehaviour
{
    public static XMLManager ins;
    public ItemDatabase itemDB;

    public void SaveItems()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
        FileStream stream = new FileStream(Application.dataPath + "/StreamingFiles/XML/item_data.xml", FileMode.Create);
        serializer.Serialize(stream, itemDB);
        stream.Close();
    }

    void Awake()
    {
        ins = this;
    }

    public void LoadItems()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
        FileStream stream = new FileStream(Application.dataPath + "/StreamingFiles/XML/item_data.xml", FileMode.Open);
        itemDB = serializer.Deserialize(stream) as ItemDatabase;
        stream.Close();
    }
}

[System.Serializable]
public class ItemEntry
{
    public string itemName;
    public Material material;
    public int value;
}

[System.Serializable]
public class ItemDatabase
{
    [XmlArray("CombatEquipment")]
    public List<ItemEntry> list = new List<ItemEntry>();
}

public enum Material
{
    Wood,
    Cooper,
    Iron,
    Steel,
    Obsidian
}