using UnityEngine;
using System.Collections;

public class PlaySoundBehaviour : MonoBehaviour {

    AudioSource _audioSource;

    [SerializeField]
    AudioClip _player_jumpAudio;
    [SerializeField]
    AudioClip _player_hitAudio;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string name)
    {
        switch(name)
        {
            case "Player_Jump":
                _audioSource.PlayOneShot(_player_jumpAudio);
                break;
            case "Player_Hit":
                _audioSource.PlayOneShot(_player_hitAudio);
                break;

        }
    }

}
