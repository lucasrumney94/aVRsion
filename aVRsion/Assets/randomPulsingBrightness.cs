using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomPulsingBrightness : MonoBehaviour {


    public float speed; 
    private Text myText;
    private float alpha;

    // Use this for initialization
    void Start ()
    {
        myText = gameObject.GetComponent<Text>();
        speed /= 10;
	}
	
	// Update is called once per frame
	void Update ()
    {
        alpha = 0.2f + 1.2f*Mathf.Abs(Mathf.Sin(speed*Time.time/2 + Mathf.PI/73 ) + Mathf.Cos(speed/21*Time.time + Mathf.PI / 31f));
        myText.color = new Color(255f, 255f, 255f, alpha);
    }
}
