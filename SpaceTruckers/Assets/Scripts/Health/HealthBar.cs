using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image currentHealth;
	public Text ratioText;
	public Health healthComponent;

	void OnEnable()
	{
		healthComponent.OnTakeDamage += UpdateHealth;
	}

	void OnDisable()
	{
		healthComponent.OnTakeDamage -= UpdateHealth;
	}

	private void Start()
	{
		UpdateHealth();
	}

	private void UpdateHealth()
	{
		float ratio = healthComponent.health / healthComponent.maxHealth;
		if(currentHealth)
		{
			currentHealth.fillAmount = ratio;
			ratioText.text = (ratio * 100).ToString() + "%";
		}
	}


}
