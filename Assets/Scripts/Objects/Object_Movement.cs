using UnityEngine;
using System.Collections;

public class Object_Movement : MonoBehaviour {

    [SerializeField]
    int _object_speed;
    Vector3 Movement;
    

    void Start()
    {
        Movement = new Vector3(Time.deltaTime * _object_speed * -1, 0, 0);
    }

    void Update()
    {
        this.transform.position += Movement;
    }
}
