using UnityEngine;
using System.Collections;

public class Death_Trigger : MonoBehaviour {

    string ThisObjectName;

    void Start()
    {
        ThisObjectName = this.gameObject.name;
        Debug.Log("Death Trigger Name: " + ThisObjectName);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(ThisObjectName != other.gameObject.name)
        {
            Debug.Log("Object Destroyed! " + other.gameObject.name);
            Destroy(other.transform.parent.gameObject); // Destroys the whole object.
            
        }
    }
}
