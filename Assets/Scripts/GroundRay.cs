using UnityEngine;

public class GroundRay : MonoBehaviour
{
    [SerializeField] private Transform _finish;
    public RaycastHit ray;
    public bool hit;

    void Update()
    {
        Debug.DrawRay(_finish.position, Vector3.up * 50);
        hit = Physics.Raycast(_finish.position, Vector3.up, out ray, 50f);
    }
}
