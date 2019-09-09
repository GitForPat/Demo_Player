using UnityEngine;

public class Player_Walk_Right : Abstract_Player_Input
{
    private string keyWalkRight_;

    private void Awake()
    {
        keyWalkRight_ = "d";
    }

    public override bool checkForKeyInput()
    {
        return Input.GetKey(keyWalkRight_); //Check to see if the associated key for this action is being held down. Then update the FSM
    }

    public override string getKeyBinding()
    {
        return keyWalkRight_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keyWalkRight_ = newKeyBinding;
    }
}
