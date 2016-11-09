# aVRsion
a VR horror game brought to you by @Lucas Rumney and @ Sherry Xueer Zhu

## Notes to contributors of this project
@author Sherry Zhu

1. InputController class is attached to SteamVR Controller left and right. Two inputController instances receive data(including boolean values and haptic feedback/ 2D index on touchpad - details see SteamVR script classes), and inform the single one InputManager class.

2. InputManager class constructs of event system and corresponding bool values of the input feedback it receives from two InputController. (For future reference, this class should only accept adding new inputs, resulting code should be easy to copy.)

3. SceneManage class conforms to the singleton patter, and should interact with the Left/RightTouchPad input values to toggle scene backwards and advancement.


### IMPORTANT
Below is the code you need to implement any methods or event that rely on controller input. Follow this, you get the benefit of knowing the object that revokes the function for a certain input.

```cs
using UnityEngine;
using System.Collections;

public class ClassName : MonoBehaviour {

[SerializeField] private InputManager m_Input;  
// Reference to the VRInput in order to know when trigger, left and right touchpad is pressed.

//subscribe methods(defined later) to input event, defined in InputManager class; Example below:
private void OnEnable ()
{
m_Input.OnLeftTouchPad += HandleLeftTouchPad; //if require LeftTouchPad input value
}

//gotta unsubscribe, sir
private void OnDisable ()
{
m_Input.OnLeftTouchPad -= HandleLeftTouchPad;
}

}

// You got it! This should work. 
```
