using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickListener : MonoBehaviour
{
    AttributesManager am = new AttributesManager();
	SkillsManager sm = new SkillsManager();
    void Start()
    {
       
    }
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
	#region Abilities Click
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
	#endregion
	#region Skills Click
	public void WarriorButton_Click()
	{
		Skills.dea();
		Skills.eea(0);
	}
	public void MagicButton_Click()
	{
		Skills.dea();
		Skills.eea(1);
	}
	public void ThiefButton_Click()
	{
		Skills.dea();
		Skills.eea(2);
	}
	public void OtherButton_Click()
	{
		Skills.dea();
		Skills.eea(3);
	}
    public void FighterClick()
    {
        sm.Unlock<Fighter>();
        sm.SkillUp(new Fighter());
    }
	#endregion
}
