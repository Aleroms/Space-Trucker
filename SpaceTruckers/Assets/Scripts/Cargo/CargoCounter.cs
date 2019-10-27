using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CargoCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counter;

    public void UpdateCounter(int newCargo)
    {
        counter.text = newCargo.ToString();
    }
}
