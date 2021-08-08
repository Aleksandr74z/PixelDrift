using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        var car = collision.gameObject.GetComponent<Car>();
        if (car)
        {            
            Destroy(gameObject);
        }
    }
}
