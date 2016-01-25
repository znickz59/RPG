using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickListener : MonoBehaviour
{
    AttributesManager am = new AttributesManager();
	SkillsManager sm = new SkillsManager();
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
	public Image[] skills = new Image[4];
	private void DisableAll()
	{
		foreach(var b in skills)
		{
			b.enabled = false;
			foreach(var v in b.GetComponentsInChildren<Image>())
			{
				v.enabled = false;
			}
		}
	}
	private void Enable(int index)
	{
		skills[index].enabled = true;
		foreach(var v in skills[index].GetComponentsInChildren<Image>())
		{
			v.enabled = true;
		}
	}
	public void WarriorButton_Click()
	{
		DisableAll ();
		Enable (0);
	}
	public void MagicButton_Click()
	{
		DisableAll ();
		Enable (1);
	}
	public void ThiefButton_Click()
	{
		DisableAll ();
		Enable (2);
	}
	public void OtherButton_Click()
	{
		DisableAll ();
		Enable (3);
	}
}
