using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _flyForce;

    [SerializeField]
    private float _maxVSpeed;

    [SerializeField]
    private float _maxHSpeed;
    
    private Rigidbody2D _rigidbody2D;
    private float _movementY;

    public float MovementY
    {
        get => _movementY;
        set => _movementY = Mathf.Clamp(value, 0, Mathf.Infinity);
    }

    public float MovementX { get; set; }
    public bool IsGrounded { get; set; }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (IsGrounded)
        {
            _rigidbody2D.velocity = new Vector2(MovementX * _speed, _rigidbody2D.velocity.y);
        }
        else
        {
            _rigidbody2D.AddForce(MovementX * _speed * Vector2.right);
        }
        
        _rigidbody2D.AddForce(MovementY * _flyForce * Vector2.up);

        _rigidbody2D.velocity = new Vector2(
            Mathf.Clamp(_rigidbody2D.velocity.x, -_maxHSpeed, _maxHSpeed),
            Mathf.Clamp(_rigidbody2D.velocity.y, -_maxVSpeed, _maxHSpeed));
    }
}
