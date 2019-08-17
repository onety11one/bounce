using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public ShopItem[] items;    

    private void Start()
    {
        foreach (var item in items)
        {
            if (item.isBought == true) // && item.isUsing == true
            {
                GetComponent<Renderer>().material = item.material;
            }
        }
        
    }
}
