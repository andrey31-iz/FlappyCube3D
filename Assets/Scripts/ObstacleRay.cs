using System.Collections;
using UnityEngine;

public class ObstacleRay : MonoBehaviour
{
    [SerializeField] private float _rayLenght;
    [SerializeField] private PlayerScore _playerScore;
    [SerializeField] private float _cooldownTimeInSeconds;
    private bool _isCanGet = true;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.up * _rayLenght, Color.red);
        bool hit = Physics.Raycast(transform.position, transform.up, out var ray, _rayLenght);
        if (hit)
        {
            if (ray.collider.CompareTag("Player") && _isCanGet)
            {
                _playerScore.Score++;
                StartCoroutine(WaitCooldown());
                Debug.Log(_playerScore.Score);
            }
        }
    }
    
    private IEnumerator WaitCooldown()
    {
        _isCanGet = false;
        yield return new WaitForSeconds(_cooldownTimeInSeconds);
        _isCanGet = true;
    }
}
