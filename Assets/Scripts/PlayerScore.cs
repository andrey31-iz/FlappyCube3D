using UnityEngine;
using System;
using System.Collections;

public class PlayerScore : MonoBehaviour
{
    public event Action<float> OnScoreChanged;

    private float _score;

    public float Score
    {
        get => _score;
        set
        {
            if (value <= float.MaxValue)
                _score = value;
            OnScoreChanged?.Invoke(_score);
        }
    }
}