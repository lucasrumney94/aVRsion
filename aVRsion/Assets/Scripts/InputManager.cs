using System.Collections;
using System;
using UnityEngine;

public class InputManager : MonoBehaviour {


	public event Action OnTrigger;                              // Called when trigger is pressed.
	public event Action OnLeftTouchPad;                          // Called when LeftTouchPad is pressed.
	public event Action OnRightTouchPad;                          // Called when RightTouchPad is pressed.

	public bool ifTrigger = false;
	public bool ifLeftTouchPad = false;
	public bool ifRightTouchPad = false;


	void Update()
	{
		Debug.Log ("trigger/left/right: " + ifTrigger, ifLeftTouchPad, ifRightTouchPad );

		if (ifTrigger = true)
		{
			// If there are any subscribers to OnTrigger call it.
			if (OnTrigger != null)
				OnTrigger();
		}

		if (ifLeftTouchPad = true)
		{
			// If there are any subscribers to OnTrigger call it.
			if (OnLeftTouchPad != null)
				OnLeftTouchPad();
		}

		if (ifRightTouchPad = true)
		{
			// If there are any subscribers to OnTrigger call it.
			if (OnRightTouchPad != null)
				OnRightTouchPad();
		}
		ifTrigger = false;
		ifLeftTouchPad = false;
		ifRightTouchPad = false;
	}


	 
	private void OnDestroy()
	{
		// Ensure that all events are unsubscribed when this is destroyed.
		OnTrigger = null;
		OnLeftTouchPad = null;
		OnRightTouchPad = null;
	}
}
