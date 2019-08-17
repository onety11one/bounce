using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text coinsText;
    //PlayerInventory playerInventory;    
    
    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItem;

    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject shopItemPrefab;    

    void Start()
    {
        //playerInventory.GetComponent<PlayerInventory>();        

        PopulateShop();
        PlayerPrefs.GetInt("TotalScore");
    }

    void PopulateShop()
    {
        for (int i = 0; i < shopItem.Length; i++)
        {
            ShopItem si = shopItem[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopContainer);
            
            itemObject.transform.GetChild(0).GetComponent<Image>().sprite = si.sprite;
            itemObject.transform.GetChild(1).GetComponent<Text>().text = si.itemName;
            itemObject.transform.GetChild(2).GetComponent<Text>().text = "$ " + si.price.ToString();
            itemObject.transform.GetChild(4).GetComponent<Button>().onClick.AddListener(() => OnBuyButtonClick(si));
        }
    }

    void OnBuyButtonClick(ShopItem item)
    {
        GameController.coins -= item.price;
        item.isBought = true;
        
        if (item.price <= GameController.coins)
        {
            Debug.Log("You bought " + item.name + " for " + item.price);
            coinsText.text = "$ " + GameController.coins;
            PlayerPrefs.SetInt("Coins", GameController.coins);
        }        
    }    
}
