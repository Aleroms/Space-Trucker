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


 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("HIT END BASE");

            int cargoCount = collision.gameObject.GetComponent<PlayerCargo>().CurrentCargo;
            Debug.Log(cargoCount);

            endMenu.SetActive(true);
        }
    }


}
