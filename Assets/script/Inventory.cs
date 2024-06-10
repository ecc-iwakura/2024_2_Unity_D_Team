using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, int> items;

    void Start()
    {
        items = new Dictionary<string, int>();
    }

    public void AddItem(string itemTag, int count)
    {
        if (items.ContainsKey(itemTag))
        {
            items[itemTag] += count;
        }
        else
        {
            items[itemTag] = count;
        }
    }

    public int GetItemCount(string itemTag)
    {
        if (items.ContainsKey(itemTag))
        {
            return items[itemTag];
        }
        else
        {
            return 0;
        }
    }

    public void PrintInventory()
    {
        foreach (var item in items)
        {
            Debug.Log(item.Key + ": " + item.Value);
        }
    }
}