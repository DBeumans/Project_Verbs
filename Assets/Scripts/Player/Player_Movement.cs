using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour  {

    float _jumpPower = 400;
    [SerializeField]
    bool _grounded;

    public bool PlayerGrounded { get { return _grounded; } set { _grounded = value; } }

    Rigidbody2D _rigidbody2D;
    PlaySoundBehaviour _playSoundBehaviour;

    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        _playSoundBehaviour = GameObject.FindObjectOfType<PlaySoundBehaviour>();
    }

    void Update()
    {
        KeyCheck();
        if(JumpKey)
        {
            if(_grounded)
            {
                _playSoundBehaviour.PlaySound("Player_Jump");
                _rigidbody2D.AddForce(Vector2.up * _jumpPower);
                _grounded = false;
            }

        }
        if(DownKey)
        {
            _rigidbody2D.AddForce(Vector2.down * _jumpPower/2);
        }
    }
}
