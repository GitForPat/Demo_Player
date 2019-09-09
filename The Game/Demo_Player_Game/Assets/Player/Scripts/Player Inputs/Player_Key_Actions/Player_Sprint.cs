using UnityEngine;

public class Player_Sprint : Abstract_Player_Input
{
    private string keySprint_;

    private void Awake()
    {
        keySprint_ = "left shift";
    }

    public override bool checkForKeyInput()
    {
        if (Input.GetKeyDown(keySprint_))
        {
            return true; //Check to see if the associated key for this action has been pressed. Then inform the state controller
        }

        if(Input.GetKeyUp(keySprint_))
        {
            return false; //Check to see if the associated key for this action has been released. Then inform the state controller
        }
        return false;
    }

    public override string getKeyBinding()
    {
        return keySprint_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keySprint_ = newKeyBinding;
    }
}
