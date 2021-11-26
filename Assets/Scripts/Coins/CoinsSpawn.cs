using UnityEngine;

public class CoinsSpawn : MonoBehaviour
{
    [SerializeField] private Coin _coin;

    private void Start()
    {
        for (int i = 0; i <= 1000; i++)
        {
            Instantiate(_coin, new Vector3(Random.Range(-500, 500), Random.Range(-500, 500)), transform.rotation);
        }
    }
}
