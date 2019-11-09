using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public int health = 100;
	public int damage = 1;

	public PlayerCargo cargo;
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			health -= damage;
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
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
