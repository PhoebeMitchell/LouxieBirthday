using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField]
    private AudioClip _flyingAudioClip;

    [SerializeField]
    private float _flyingAudioPitch;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayFlying(bool shouldNotPlayFlying)
    {
        if (shouldNotPlayFlying)
        {
            _audioSource.Stop();
        }
        else
        {
            _audioSource.pitch = _flyingAudioPitch;
            _audioSource.clip = _flyingAudioClip;
            _audioSource.Play();
        }
    }
}
