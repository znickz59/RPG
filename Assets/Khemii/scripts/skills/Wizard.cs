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
		skillEffect = Effect ( Hero.Abils.Willpower);
	}

    protected internal override decimal Effect<TAbility>(TAbility Ability)
    {
        return (decimal.Parse(Ability.ToString()) * (decimal)stage * 0.01m);
    }
    protected internal override Stage SkillUp ()
	{
		if(stage == Stage.Best) return stage;
		return ++stage;
	}
		
	}

