using UnityEngine;

public class Player_Crouch : Abstract_Player_Input
{
    private string keyCrouch_;

    private void Awake()
    {
        keyCrouch_ = "left ctrl";
    }

    public override bool checkForKeyInput()
    {
        if (Input.GetKeyDown(keyCrouch_))
        {
            return true; //Check to see if the associated key for this action has been pressed. Then inform the state controller
        }

        if (Input.GetKeyUp(keyCrouch_))
        {
            return false; //Check to see if the associated key for this action has been released. Then inform the state controller
        }
        return false;
    }

    public override string getKeyBinding()
    {
        return keyCrouch_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keyCrouch_ = newKeyBinding;
    }
}
