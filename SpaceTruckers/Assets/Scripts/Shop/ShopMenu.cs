using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{

    public static ShopMenu instance;

    [SerializeField] ShopElement[] shop_elements;
    [SerializeField] TextMeshProUGUI coin;

    private void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        coin.text = "Coin: " + GameManager.instance.currency;
    }

    public ShopElement[] GetAllShopElements()
    {
        return shop_elements;
    }
}
