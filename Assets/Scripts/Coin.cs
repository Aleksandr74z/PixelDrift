using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject _particleCoin;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        var car = collision.gameObject.GetComponent<Car>();
        if (car)
        {            
            Destroy(gameObject);
            Instantiate(_particleCoin, transform.position, transform.rotation);
        }
    }
}
