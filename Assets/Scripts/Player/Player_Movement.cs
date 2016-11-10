using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour  {

    float _jumpPower = 300;
    [SerializeField]
    bool _grounded;

    public bool PlayerGrounded { get { return _grounded; } set { _grounded = value; } }

    Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        KeyCheck();
        if(JumpKey)
        {
            if(_grounded)
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpPower);
                _grounded = false;
            }

        }
    }
}
