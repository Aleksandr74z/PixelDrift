using System;
using UnityEngine;

public class GameSessions : MonoBehaviour
{
    private int _score = 0;

    public event Action<int> OnScoreChanged;

    public int Score => _score;

    public void AppScore(int score)
    {
        _score += score;
        OnScoreChanged?.Invoke(_score);
    }
}
