using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _acceleration;

    public float Thrust;
    public float RotationDirection;

    private Rigidbody2D _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (RotationDirection != 0 && Thrust != 0)
        {
            _body.angularVelocity = -RotationDirection * _rotationSpeed;
        }

        if (Thrust > 0)
        {
            Vector2 accelerationdelta = transform.up * _acceleration;
            _body.velocity += accelerationdelta;
        }
    }
}
