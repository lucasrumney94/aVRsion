using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// This class allows the user to return to safe zone and navigate to the previous and next scene.
// The class uses the singleton pattern so that only one object exists.
public class SceneManage : MonoBehaviour {
	
	[SerializeField] private InputManager m_Input;  // Reference to the VRInput in order to know when trigger, left and right touchpad is pressed.
	[SerializeField] private int level; 

	public static SceneManage instance = null;

	void Awake() 
	{
		if (instance == null) 
		{
			instance = this;
		} else if (instance != this) 
		{
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}

	void Start() 
	{
		level = 0;
	}


	private void OnEnable ()
	{
		m_Input.OnTrigger += HandleTrigger;
		m_Input.OnLeftTouchPad += HandleLeftTouchPad;
		m_Input.OnRightTouchPad += HandleRightTouchPad;
	}


	private void OnDisable ()
	{
		m_Input.OnTrigger -= HandleTrigger;
		m_Input.OnLeftTouchPad -= HandleLeftTouchPad;
		m_Input.OnRightTouchPad -= HandleRightTouchPad;
	}


	private void HandleTrigger ()
	{
		GoToSafeZone();
	}


	private void HandleLeftTouchPad ()
	{
		level--; 
		SceneManager.LoadScene(level, LoadSceneMode.Single);
	}


	private void HandleRightTouchPad ()
	{
		level++; 
		SceneManager.LoadScene(level, LoadSceneMode.Single);	
	}


	private void GoToSafeZone ()
	{
		// scripts for transforming player's position to the safe zone in the scene.
	}


}
