using UnityEngine;
using System.Collections;

public class Object_Movement : MonoBehaviour {

    [SerializeField]
    int _object_speed;

    Rigidbody2D _rigidbody2d;

    void Start()
    {
        _rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rigidbody2d.AddForce(Vector2.left * _object_speed);
    }
}
