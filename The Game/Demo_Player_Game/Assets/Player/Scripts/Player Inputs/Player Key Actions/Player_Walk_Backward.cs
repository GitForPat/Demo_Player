using UnityEngine;

public class Player_Walk_Backward : Abstract_Player_Input
{
    private string keyWalkBackward_;

    private void Awake()
    {
        keyWalkBackward_ = "s";
    }

    public override bool checkForKeyInput()
    {
        return Input.GetKey(keyWalkBackward_); //Check to see if the associated key for this action is being held down. Then update the FSM
    }

    public override string getKeyBinding()
    {
        return keyWalkBackward_;
    }

    public override void setKeyBinding(string newKeyBinding)
    {
        keyWalkBackward_ = newKeyBinding;
    }
}
