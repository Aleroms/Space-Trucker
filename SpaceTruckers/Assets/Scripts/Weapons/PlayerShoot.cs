using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] KeyCode shootButton;
    [SerializeField] ObjectPool pool;
    [SerializeField] float timeBetweenBullets;


    bool isShooting = false;
    private void Update()
    {
        if(Input.GetKey(shootButton))
        {
            if(!isShooting)
            {
                StartCoroutine(Shoot());
            }
        }
    }
    
    IEnumerator Shoot()
    {
        isShooting = true;
        GameObject bullet = pool.GetUnusedObject();
        bullet.SetActive(true);
        yield return new WaitForSeconds(timeBetweenBullets);
        isShooting = false;
    }

}
