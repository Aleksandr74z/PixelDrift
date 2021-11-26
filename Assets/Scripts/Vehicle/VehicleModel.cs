using System;

public class VehicleModel
{
    public event Action StopVehicle;
    public event Action<float> ChangedFuel;

    private float _maxFuel = 100;
    private float _currentFuel;

    public VehicleModel()
    {
        _currentFuel = _maxFuel;
    }

    public void SetNewHealth(int damage)
    {
        _currentFuel -= damage;
        if (_currentFuel > 0)
            ChangedFuel?.Invoke(_currentFuel);
        else
            StopVehicle?.Invoke();
    }
}
