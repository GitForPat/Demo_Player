using UnityEngine;
using System.Collections.Generic;

public class Player_Key_Inputs : MonoBehaviour {
    [SerializeField] private Player_Walk_Backward playerWalkBackward_;
    [SerializeField] private Player_Walk_Left playerWalkLeft_;
    [SerializeField] private Player_Walk_Right playerWalkRight_;
    [SerializeField] private Player_Walk_Forward playerWalkForward_;
    [SerializeField] private Player_Sprint playerSprint_;
    [SerializeField] private Player_Jump playerJump_;
    [SerializeField] private Player_Crouch playerCrouch_;

    private List<Abstract_Player_Input> allInputOptions_;

    private void Awake()
    {
        allInputOptions_ = new List<Abstract_Player_Input>();
        allInputOptions_.Add(playerWalkBackward_);
        allInputOptions_.Add(playerWalkLeft_);
        allInputOptions_.Add(playerWalkRight_);
        allInputOptions_.Add(playerWalkForward_);
        allInputOptions_.Add(playerSprint_);
        allInputOptions_.Add(playerJump_);
        allInputOptions_.Add(playerCrouch_);
    }

    public void inputCheck()
    {
        foreach (var inputs in allInputOptions_)
        {
            inputs.checkForKeyInput(); //Loop through every single action a player can make and see if the associated key with that action has been pressed/held.
        }
    }
}
