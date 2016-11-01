using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    // Keyboard
    private bool jump = false;
    private bool escapeButton = false;
    private bool down = false;

    // Use the public bool to read the keystatement

    // Read only
    public bool JumpKey { get { return jump; } }
    public bool EscapeKey { get { return escapeButton; } }
    public bool DownKey { get { return down; } }

    // Controller
    private bool controller_up;
    private bool controller_down;

    // Use the public bool to read the keystatement

    // Read only
    public bool Controller_Up_Key { get { return controller_up; } }
    public bool ControllerDown_Key { get { return controller_down; } }

    // Keyboard
    KeyCode Jump = KeyCode.Space;
    KeyCode EscapeButton = KeyCode.Escape;
    KeyCode Down = KeyCode.S;

    // Controller
    KeyCode Controller_Up = KeyCode.Joystick1Button16;
    KeyCode Controller_Down = KeyCode.Joystick1Button18;

    public void KeyCheck()
    {
        // Keyboard
        jump = Input.GetKeyDown(Jump);
        escapeButton = Input.GetKeyDown(EscapeButton);
        down = Input.GetKey(Down);

        // Controller
        controller_up = Input.GetKey(Controller_Up);
        controller_down = Input.GetKey(Controller_Down);
    }
}
