using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// This class allows the user to navigate to the previous and next scene.
// The class uses the singleton pattern so that only one object exists.
public class SceneManage : MonoBehaviour {

    [SerializeField] private InputManager m_Input;  // Reference to the VRInput in order to know when trigger, left and right touchpad is pressed.
	public int level; 

 
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
        //FindObjectOfType<InputManager>().OnTrigger
    }
    

	void Update() 
	{
		Debug.Log("Current level: " + SceneManager.GetActiveScene().buildIndex + "should be: " + level);
	}


	private void OnEnable ()
	{
		m_Input.OnLeftTouchPad += HandleLeftTouchPad;
		m_Input.OnRightTouchPad += HandleRightTouchPad;
	}


	private void OnDisable ()
	{
		m_Input.OnLeftTouchPad -= HandleLeftTouchPad;
		m_Input.OnRightTouchPad -= HandleRightTouchPad;
	}


	private void HandleLeftTouchPad ()
	{
		Debug.Log ("Handle left is executed.");
		level--; 
		SceneManager.LoadScene(level);
	}


	private void HandleRightTouchPad ()
	{
        Debug.Log("Handle right is executed.");
        level++; 
		SceneManager.LoadScene(level);	
	}




}
