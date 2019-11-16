using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopElement : MonoBehaviour
{

    [SerializeField] Button button;
    TextMeshProUGUI button_text;
    [SerializeField] bool is_purhcased = false;
    [SerializeField] bool is_selected = false;
    [SerializeField] int price = 0;

    ShopElement[] shop_elements;

    // Start is called before the first frame update
    void Start()
    {
        button_text = button.GetComponentInChildren<TextMeshProUGUI>();
        shop_elements = ShopMenu.instance.GetAllShopElements();

        if (is_selected)
        {
            button_text.text = "Selected";
        }
        else if (!is_purhcased)
        {
            button_text.text = price.ToString();
        }
        else
        {
            button_text.text = "Purchased";
        }
    }

    public void ClickedOnButton()
    {
 
        if (price > GameManager.instance.currency)
        {
            Debug.Log("Not enough money");
            return;
        }

        foreach (ShopElement e in shop_elements)
        {
            e.ResetButtonText();
        }

        button_text.text = "Selected";
        GameManager.instance.currency -= price;
        is_purhcased = true;
        is_selected = true;
    }

    void ResetButtonText()
    {
        is_selected = false;
        if (is_purhcased)
        {
            button_text.text = "Purchased";
        }
        else
        {
            button_text.text = price.ToString();
        }
    }
}
