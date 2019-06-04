using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Item currentItem;
    public Text displayText;

    public void SelectItem(Item item)
    {
        currentItem = item;
        displayText.text = "Selected Item: " + currentItem.itemName;
    }
}
