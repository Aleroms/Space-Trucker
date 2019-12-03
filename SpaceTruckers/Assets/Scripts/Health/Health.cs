using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public float maxHealth = 100;
	public float health = 100;
	public float damage = 1; //if you make an enemy script, move this damage variable over to there

	public PlayerCargo cargo;

	public delegate void TakeDamage();
	public TakeDamage OnTakeDamage;
  
    public GameObject gameOverScreen;


    private void Start()
    {
        gameOverScreen.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			health -= damage;
			health = Mathf.Clamp(health, 0, Mathf.Infinity);
			OnTakeDamage();
            if (health == 0)
            {
                gameOverScreen.SetActive(true);
            }
            print("health:" + health );

			if (cargo)
			{
				print(cargo.CurrentCargo);
				cargo.subtractCargo(1);
			}
			else
				print("PlayerCargo script reference is null");
		}
	}

}
