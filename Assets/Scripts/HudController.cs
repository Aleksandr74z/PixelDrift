using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    [SerializeField] private Text _score;
    [SerializeField] private Text _distance;
    [SerializeField] private Text _speed;
    [SerializeField] private Text _angle;
    [SerializeField] private GameOverOverlay _gameOver;
    [SerializeField] private Slider _slider;

    private GameSessions _session;
    private CounterDistance _counterDistance;
    private FuelMachine _fuelMachine;

    private void Start()
    {
        _session = FindObjectOfType<GameSessions>();
        _session.OnScoreChanged += ScoreChangeHandler;

        _counterDistance = FindObjectOfType<CounterDistance>();
        _counterDistance.OnDistanceChanged += DistanceChangeHandler;
        _counterDistance.OnSpeedChanged += DeterminationSpeed;
        _counterDistance.OnAngleChanged += AngleChangeHandler;

        _fuelMachine = FindObjectOfType<FuelMachine>();
        _fuelMachine.OnFuelChanged += SetFuel;

    }

    private void ScoreChangeHandler(int score)
    {
        _score.text = "SCORE: " + score.ToString();
    }

    private void DistanceChangeHandler(int distance)
    {
        _distance.text = distance.ToString();
    }

    private void DeterminationSpeed(int distanceOnFrame)
    {
        _speed.text = distanceOnFrame.ToString();
    }

    private void SetFuel(int value)
    {
        _slider.value = value;
    }

    private void AngleChangeHandler(int angle)
    {
        _angle.text = angle.ToString();
    }



}
