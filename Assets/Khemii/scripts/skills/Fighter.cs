using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    class Fighter : Skill
    { 
	private static uint skillEffect;
	private static new Stage stage = Stage.Basic;
	internal static Stage S {get{return stage;}}
	internal static uint SkillEffect {get{return skillEffect;}}
    void Start()
    {

    }
    void FixedUpdate()
    {
		skillEffect = Effect (0, Hero.Abils.Strength);
    }
	protected internal override uint Effect<TAbility> (int index, params TAbility[] Abilities)
	{
		if(Abilities.Length == 0) throw new Exception();
		return (uint.Parse(Abilities[index].ToString ()) * (uint)stage);
	}
	protected internal override Stage SkillUp ()
	{
		return ++stage;
	}
    }

