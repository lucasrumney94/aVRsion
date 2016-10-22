using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBillboard : MonoBehaviour {

    public float speed = 1.0f;
    private float myRandomOffset;

	// Use this for initialization
	void Start ()
    {
        transform.LookAt(-1*GameObject.FindGameObjectWithTag("MainCamera").transform.position);
        transform.Rotate(new Vector3(0f, 0f, 180f));
        myRandomOffset = Random.Range(-180, 180);
        transform.Rotate(new Vector3(myRandomOffset, 0f, 0f));
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.right,speed);
	}
}
