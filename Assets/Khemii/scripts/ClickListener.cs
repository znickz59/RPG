using UnityEngine;
using System.Collections;

public class ClickListener : MonoBehaviour
{
    AttributesManager am = new AttributesManager();
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
    public void StrengthButton_Click()
    {
        am.StrengthUp();
    }
    public void VitalityButton_Click()
    {
        am.VitalityUp();
    }
    public void IntelligenceButton_Click()
    {
        am.IntelligenceUp();
    }
    public void WillpowerButton_Click()
    {
        am.WillpowerUp();
    }
    public void DexterityButton_Click()
    {
        am.DexterityUp();
    }
    public void EnduranceButton_Click()
    {
        am.EnduranceUp();
    }
}
