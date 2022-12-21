using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    private Rigidbody _rigidbody;
    private bool _isCanJump;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _isCanJump = true;
    }


    private void FixedUpdate()
    {
        if (_isCanJump)
        {
            Jump();
            _isCanJump = false;
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = new Vector3(0, _jumpForce, 0);
    }
}