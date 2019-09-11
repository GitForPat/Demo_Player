using UnityEngine;

public class Player_Walk_Forward : Abstract_Player_Input
{
    private string keyWalkForward_;

    private void Awake()
    {
        keyWalkForward_ = "w";
    }

    public override bool checkForKeyInput()
    {
        return Input.GetKey(keyWalkForward_); //Check to see if the associated key for this action is being held down. Then update the FSM
    }

    public override string getKeyBinding()
    {
        return keyWalkForward_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keyWalkForward_ = newKeyBinding;
    }
}
