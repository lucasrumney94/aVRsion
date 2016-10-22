using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManager : MonoBehaviour {
	//Declare SceneManager as a singleton
	public static SceneManager instance = null;

	[SerializeField]
	private int level = 0; 

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
		
	void Start () 
	{
		
	}
	
	void Update () 
	{
		// get input and shit

		Debug.Log ("Safe Zone Button Pressed!");
	}
}
