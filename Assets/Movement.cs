
using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    [SerializeField]
    float speed;
    Vector3 walk = new Vector3();

	// Use this for initialization
	void Start () {
        walk = new Vector3(0.05f * speed, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += walk;
	}
}
