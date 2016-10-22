using System;
using UnityEngine;

public class InputController : MonoBehaviour {

	
	private SteamVR_TrackedObject trackedObject;
	private SteamVR_Controller.Device device;

	public InputManager inputMan;


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
		if (device.GetPressDown (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("Trigger Pressed!");

			inputMan.ifTrigger = true;



		} else	
		{
			inputMan.ifTrigger = false;
		}

		// check if left touch pad is pressed
		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad) && gameObject.name == "Controller (left)") 
		{
			Debug.Log ("Left Touchpad Pressed!");

			inputMan.ifLeftTouchPad = true;

		}else	
		{
			inputMan.ifLeftTouchPad = false;
		}

		// check if right touch pad is pressed
		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad) && gameObject.name == "Controller (right)") 
		{
			Debug.Log ("Right Touchpad Pressed!");

			inputMan.ifRightTouchPad = true;

		}else	
		{
			inputMan.ifRightTouchPad = false;
		}

	}


}
