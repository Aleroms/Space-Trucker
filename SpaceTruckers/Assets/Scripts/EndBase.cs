using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBase : MonoBehaviour
{

    [SerializeField] GameObject endMenu; 

    // Start is called before the first frame update
    void Start()
    {
        endMenu.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int cargoCount = collision.gameObject.GetComponent<PlayerCargo>().CurrentCargo;
            Debug.Log(cargoCount);

            endMenu.SetActive(true);
        }
    }
}
