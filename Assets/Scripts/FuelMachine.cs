using System;
using System.Collections;
using UnityEngine;

public class FuelMachine : MonoBehaviour
{
    public static int _fuel = 100;

    public event Action<int> OnFuelChanged;

    private void Start()
    {
        StartFuelConsumption();
    }

    public void StartFuelConsumption()
    {
        StopAllCoroutines();
        StartCoroutine(FuelConsumption(_fuel));
    }

    private IEnumerator FuelConsumption(int fuel)
    {
        for (int i = fuel; i > 0; i--)
        {
            OnFuelChanged?.Invoke(i);
            yield return new WaitForSeconds(1f);
            //Debug.Log(i);
        }
    }
}
