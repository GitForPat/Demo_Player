using UnityEngine;

public class Player_Jump : Abstract_Player_Input
{
    private string keyJump_;

    private void Awake()
    {
        keyJump_ = "space";
    }

    public override bool checkForKeyInput()
    {
        if (Input.GetKeyDown(keyJump_))
        {
            return true; //Check to see if the associated key for this action has been pressed. Then inform the state controller
        }

        if (Input.GetKeyUp(keyJump_))
        {
            return false; //Check to see if the associated key for this action has been released. Then inform the state controller
        }
        return false;
    }

    public override string getKeyBinding()
    {
        return keyJump_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keyJump_ = newKeyBinding;
    }
}
