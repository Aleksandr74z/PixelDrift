using System;
using UnityEngine;

public class GameSessions : MonoBehaviour
{
    [SerializeField] private VehicleView _playerPrefab;

    private VehicleModel _vehicleModel;
    private VehiclePresenter _vehiclePresenter;

    public void Start()
    {
        _vehicleModel = new VehicleModel();
        var playerObject = Instantiate(_playerPrefab, Vector3.zero, Quaternion.identity);
        var vehicleView = playerObject.GetComponent<VehicleView>();

        _vehiclePresenter = new VehiclePresenter(vehicleView, _vehicleModel);

    }














    private int _score = 0;

    public event Action<int> OnScoreChanged;
    public int Score => _score;

    public void AppScore(int score)
    {
        _score += score;
        OnScoreChanged?.Invoke(_score);
    }
}
