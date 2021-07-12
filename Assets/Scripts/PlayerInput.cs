using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerController _player;

   
    private void Update()
    {
        _player.RotationDirection = Input.GetAxis("Horizontal");
        _player.Thrust = Input.GetAxis("Vertical");
    }
}
