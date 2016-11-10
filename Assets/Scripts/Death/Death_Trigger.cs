using UnityEngine;
using System.Collections;

public class Death_Trigger : MonoBehaviour {

    string ThisObjectName;

    void Start()
    {
        ThisObjectName = this.gameObject.name;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(ThisObjectName != other.gameObject.name)
        {
            Destroy(other.gameObject); // Destroys the whole object.
            
        }
    }
}
