using UnityEngine;
using System.Collections;

public class ClickListener : MonoBehaviour
{
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt)) && Input.GetKey(KeyCode.F4)) Application.Quit();
    }
    public void NewGame()
    {
        Application.LoadLevel("createCharacter");
    }
	public void ExitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        Application.LoadLevel("gameStart");
    }
}
