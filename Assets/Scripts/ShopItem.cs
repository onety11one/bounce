﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Shop Item")]
public class ShopItem : ScriptableObject
{
    public string itemName;
    public Sprite sprite;
    public int price;
    public Material material;

    public bool isBought;
    public bool isUsing;
    
}
