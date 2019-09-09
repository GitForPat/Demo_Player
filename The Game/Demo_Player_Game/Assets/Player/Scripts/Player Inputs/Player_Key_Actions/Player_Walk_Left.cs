using UnityEngine;

public class Player_Walk_Left : Abstract_Player_Input
{
    private string keyWalkLeft_;

    private void Awake()
    {
        keyWalkLeft_ = "a";
    }

    public override bool checkForKeyInput()
    {
        return Input.GetKey(keyWalkLeft_); //Check to see if the associated key for this action is being held down. Then update the FSM
    }

    public override string getKeyBinding()
    {
        return keyWalkLeft_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keyWalkLeft_ = newKeyBinding;
    }
}
