using UnityEngine;

abstract public class Abstract_Player_Input : MonoBehaviour
{
    abstract public bool checkForKeyInput();
    abstract public string getKeyBinding();
    abstract public void setKeyBinding(string newKeyBinding);
}
