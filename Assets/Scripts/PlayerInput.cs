using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        _playerMovement.MovementY = Input.GetAxisRaw("Vertical");
        _playerMovement.MovementX = Input.GetAxisRaw("Horizontal");
    }
}
