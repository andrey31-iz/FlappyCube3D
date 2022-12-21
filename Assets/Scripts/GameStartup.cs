using UnityEngine;

public class GameStartup : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }
}
