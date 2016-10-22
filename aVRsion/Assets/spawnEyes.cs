using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEyes : MonoBehaviour {

    public GameObject eyePrefab;
    public int numberOfEyes = 50;
    public float maxDistance = 50.0f;
    public float minDistance = 10.0f;
    public float flatness = 50.0f;
    

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < numberOfEyes; i++)
        {
            Vector3 EyePosition = maxDistance * Random.insideUnitSphere;
            EyePosition = new Vector3(EyePosition.x+minDistance, 0.1f + (1/flatness) * Mathf.Abs(EyePosition.y), EyePosition.z+minDistance);
            
            GameObject go = GameObject.Instantiate(eyePrefab, EyePosition, Quaternion.identity);
            go.transform.SetParent(this.transform);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
