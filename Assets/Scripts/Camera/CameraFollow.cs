using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private int _cameraZoom = -30;

    private void Update()
    {
        transform.position = _player.transform.position + new Vector3(0, 0, _cameraZoom);
    }
}
