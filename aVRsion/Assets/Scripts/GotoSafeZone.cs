using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class allows the user to return to safe zone.
public class GotoSafeZone : MonoBehaviour {

	[SerializeField] private InputManager m_Input;  // Reference to the VRInput in order to know when trigger, left and right touchpad is pressed.

	public Vector3 safePlace = new Vector3();

	void Start() 
	{
		//safePlace = new Vector3 ();
	}

	private void OnEnable ()
	{
		m_Input.OnTrigger += HandleTrigger;
	}


	private void OnDisable ()
	{
		m_Input.OnTrigger -= HandleTrigger;
	}


	private void HandleTrigger ()
	{
		GoToSafeZone();
	}


	private void GoToSafeZone ()
	{
		// scripts for transforming player's position to the safe zone in the scene.
		gameObject.transform.position = safePlace;
		Debug.Log ("Current Player position: " + gameObject.transform.position);

	}
}
