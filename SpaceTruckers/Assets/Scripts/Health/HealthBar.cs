using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image currentHealth;
	public Text ratioText;

	private float maxHealth = 100;
	private float damage = 100;

	private void Start()
	{
		UpdateHealth();
		
	}

	//public void 

	private void UpdateHealth()
	{
		float ratio = damage / maxHealth;
		if(currentHealth)
		{
			currentHealth.rectTransform.localScale = new Vector3(ratio,1.0f,1.0f);
			ratioText.text = (ratio * 100.0f).ToString("0") + '%';

		}
	}

	public void TakeDamage(float dmg)
	{
		damage -= dmg;

		if (damage < 0)
			damage = 0;

		UpdateHealth();
	}
}
