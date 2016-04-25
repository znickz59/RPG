using System;
using UnityEngine;

	public class Wizard : Skill
	{
	private static decimal skillEffect = 0;
	private static new Stage stage = Stage.Basic;
	internal static Stage S { get { return stage; } }
	internal static decimal SkillEffect { get { return skillEffect; } }
	void Start()
	{

	}

	void FixedUpdate()
		{
		skillEffect = Effect (0, Hero.Abils.Willpower);
	}

	protected internal override decimal Effect<TAbility> (int index, params TAbility[] Abilities)
	{
		if(Abilities.Length == 0) throw new Exception();
		return (decimal.Parse(Abilities[index].ToString ()) * (decimal)stage * 0.01m);
	}
	protected internal override Stage SkillUp ()
	{
		if(stage == Stage.Best) return stage;
		return ++stage;
	}
		
	}

