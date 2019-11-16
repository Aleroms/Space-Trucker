using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int currency;

    public int rewardPerCollectedCargo = 5;

    

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }


    public void IncreaseCurrencyBy(int income)
    {
        currency += income;
        Debug.Log("Total User Money is now: " + currency);
    }



}
