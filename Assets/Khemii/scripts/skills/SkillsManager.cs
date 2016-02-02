using System;
using UnityEngine; 

	public class SkillsManager
	{
	internal void Unlock<TSkill>() where TSkill : Skill
	{
		GameObject.Find ("Skills").GetComponentInChildren<TSkill>().enabled = true;
	}

	internal void SkillUp<TSkill>(TSkill ts) where TSkill : Skill
	{
		ts.SkillUp ();
	}

	}


