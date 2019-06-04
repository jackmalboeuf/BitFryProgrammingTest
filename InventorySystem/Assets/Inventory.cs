using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Item currentItem;
    public Text displayText;
    public Text inventoryText;
    public Text statusText;

    List<string> inventoryItems = new List<string>();

    public void SelectItem(Item item)
    {
        currentItem = item;
        displayText.text = "Selected Item: " + currentItem.itemName;
    }

    public void AddItem()
    {
        if (currentItem != null && !inventoryItems.Contains(currentItem.itemName))
        {
            inventoryItems.Add(currentItem.itemName);

            RefreshInventoryDisplay();
        }
    }

    public void UseItem()
    {
        if (currentItem != null && inventoryItems.Contains(currentItem.itemName))
        {
            inventoryItems.Remove(currentItem.itemName);

            RefreshInventoryDisplay();
        }
    }

    public void ConsumeItem()
    {
        if (currentItem != null && inventoryItems.Contains(currentItem.itemName))
        {
            statusText.text = currentItem.itemStatus;

            inventoryItems.Remove(currentItem.itemName);

            RefreshInventoryDisplay();
        }
    }

    void RefreshInventoryDisplay()
    {
        string inventoryReadout = "";

        foreach (string item in inventoryItems)
        {
            inventoryReadout += string.Format("{0}\n", item);
        }

        inventoryText.text = inventoryReadout;
    }
}
