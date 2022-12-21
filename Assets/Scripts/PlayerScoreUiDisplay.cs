using System;
using TMPro;
using UnityEngine;

public class PlayerScoreUiDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private PlayerScore _playerScore;
    
    private void UpdatePlayerScore(float score)
    {
        _scoreText.text = _playerScore.Score.ToString();
    }

    private void OnEnable()
    {
        _playerScore.OnScoreChanged += UpdatePlayerScore;
    }

    private void OnDisable()
    {
        _playerScore.OnScoreChanged -= UpdatePlayerScore;
    }
}