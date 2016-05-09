using UnityEngine;
using System.Collections;
using System;

public class Archer : Skill
{
   
    void Start ()
    {
	
	}

	void Update ()
    {
	
	}
    protected internal override decimal Effect<TAbility>(TAbility Ability)
    {
        return (decimal.Parse(Ability.ToString()) * (decimal)stage * 0.01m);
    }
}
