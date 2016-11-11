using UnityEngine;
using System.Collections;

public class Object_Movement : MonoBehaviour {

    float MovementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MovementSpeed * Time.deltaTime);
    }
}
