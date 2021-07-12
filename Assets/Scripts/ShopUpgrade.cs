using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUpgrade : MonoBehaviour
{
    
    private void Start()
    {
        
    }


    public void UpgradeFuel()
    {
        FuelMachine._fuel += 10;
    }
}
