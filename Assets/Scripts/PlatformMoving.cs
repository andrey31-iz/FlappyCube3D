using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    public Transform _start;
    public Transform _finish;
    [SerializeField] private PlatformStorage _storage;
    [SerializeField] private int _indexInStorage;
    private Transform[] _platforms;
    private bool _hit;

    private void Start()
    {
        _platforms = _storage.Platforms;
    }

    private void Update()
    {
        _hit = GetComponent<GroundRay>().hit;

        if (_hit)
        {
            _platforms[_indexInStorage].transform.position =
                 _platforms[_indexInStorage + 1].GetComponent<PlatformMoving>()._finish.position + transform.position;
        }
    }
}
