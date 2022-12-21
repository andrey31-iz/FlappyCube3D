using UnityEngine;

public class PlayerObstacleHandler : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private PlayerScore _playerScore;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            transform.position = _spawnPosition.position;
            _playerScore.Score = 0;
        }
    }
}