using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCargo : MonoBehaviour
{
    [SerializeField] CargoCounter cargo;
    [SerializeField] int startingCargo = 0;

    int currentCargo;
    public int CurrentCargo
    {
        get { return currentCargo; }
        set
        {
            currentCargo = value;
            UpdateCargoAmount(currentCargo);
        }
    }
    public delegate void UpdateCargo(int newCargo);
    public event UpdateCargo UpdateCargoAmount;

    private void Start()
    {
        UpdateCargoAmount += cargo.UpdateCounter;
        CurrentCargo = startingCargo;
    }

    public void PickedUpCargo()
    {
        CurrentCargo += 1;
    }
	public void subtractCargo(int amount)
	{
		if (CurrentCargo > 0)
		{
			CurrentCargo -= amount;
		}

}
