using UnityEngine;

public class Car : MonoBehaviour
{
    private int _score = 1;
       
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var coin = collision.gameObject.GetComponent<Coin>();
        var fuel = collision.gameObject.GetComponent<Fuel>();

        if (coin)
        {
            var session = FindObjectOfType<GameSessions>();
            session.AppScore(_score);
        }

        if (fuel)
        {
            var fuelmash = FindObjectOfType<FuelMachine>();
            fuelmash.StartFuelConsumption();
        }

    }
    
}
