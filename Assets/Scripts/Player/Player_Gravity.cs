using UnityEngine;
using System.Collections;

public class Player_Gravity : MonoBehaviour {

    [SerializeField]
    float _gravity;

    Rigidbody2D _rigidbody2d;

    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rigidbody2d.AddForce(Vector2.down * _gravity);
    }
}
