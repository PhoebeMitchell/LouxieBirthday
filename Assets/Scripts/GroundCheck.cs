using UnityEngine;
using UnityEngine.Events;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private UnityEvent<bool> _onGroundedChanged;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _onGroundedChanged.Invoke(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _onGroundedChanged.Invoke(false);
    }
}
