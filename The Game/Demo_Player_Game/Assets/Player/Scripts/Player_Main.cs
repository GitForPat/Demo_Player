using UnityEngine;

public class Player_Main : MonoBehaviour {
    [SerializeField] private Player_Key_Inputs playerKeyInput_;

    private void Update()
    {
        playerKeyInput_.inputCheck();
    }
}
