using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Animator _animator;

    public bool IsFlying
    {
        set => _animator.SetBool("Flying", !value);
    }

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _animator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        var moving = !Mathf.Approximately(_playerMovement.MovementX, 0);
        if (moving)
        {
            transform.localScale =
                new Vector3(Mathf.Abs(transform.localScale.x) * Mathf.Sign(_playerMovement.MovementX),
                    transform.localScale.y, transform.localScale.z);
        }

        _animator.SetBool("Moving", moving);
    }
}
