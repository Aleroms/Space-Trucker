using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndMenu : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI moneyAmountText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        //Time.timeScale = 0;
        int collectedCargo = GameObject.FindWithTag("Player").GetComponent<PlayerCargo>().CurrentCargo;
        Debug.Log("Collected cargo " + collectedCargo);
        int calculatedReward = collectedCargo * GameManager.instance.rewardPerCollectedCargo;
        moneyAmountText.text = "Cargo collected: " + collectedCargo + " x $" + GameManager.instance.rewardPerCollectedCargo + " = $" + calculatedReward;
        GameManager.instance.IncreaseCurrencyBy(calculatedReward);
    }

    public void RestrartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
