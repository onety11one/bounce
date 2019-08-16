using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItem;

    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject shopItemPrefab;

    public GameObject confirmPanel;
    public Text confirmText;

    void Start()
    {
        PopulateShop();
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
        Debug.Log("Do you wish to buy " + item.name + " for " + item.price +"?");
        confirmPanel.SetActive(true);
        confirmText.text = "Do you wish to buy " + item.name + " for " + item.price + "?";
    }

    public void BuyConfirm(ShopItem item) //?????
    {
        Debug.Log("bought for" + item.price);
    }
}
