using System;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public event Action OnTrigger;                              // Called when trigger is pressed.
	public event Action OnLeftTouchPad;                          // Called when LeftTouchPad is pressed.
	public event Action OnRightTouchPad;                          // Called when RightTouchPad is pressed.

	
	private SteamVR_TrackedObject trackedObject;
	private SteamVR_Controller.Device device;


	void Start () 
	{
		trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	void Update () 
	{
		device = SteamVR_Controller.Input((int)trackedObject.index);

		CheckInput();


	}

	private void CheckInput()
	{
		// check if trigger is pressed
		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)) 
		{
			Debug.Log ("Trigger Pressed!");

			// If there are any subscribers to OnTrigger call it.
			if (OnTrigger != null)
				OnTrigger();

		}

		// check if left touch pad is pressed
		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad) && gameObject.name == "Controller (left)") 
		{
			Debug.Log ("Left Touchpad Pressed!");

			if (OnLeftTouchPad != null)
				OnLeftTouchPad();

		}

		// check if right touch pad is pressed
		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad) && gameObject.name == "Controller (right)") 
		{
			Debug.Log ("Right Touchpad Pressed!");

			if (OnRightTouchPad != null)
				OnRightTouchPad();
		}

	}

	private void OnDestroy()
	{
		// Ensure that all events are unsubscribed when this is destroyed.
		OnTrigger = null;
		OnLeftTouchPad = null;
		OnRightTouchPad = null;
	}

}
