using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Scripting;
public delegate void AttributesChangedEventArgs();
public delegate void AttributesModifyEventArgs(uint value);
    public class AttributesManager
    {
	//public event AttributesChangedEventArgs attributeChanged = ()=>{};
	//public event AttributesModifyEventArgs attributeModified = i => {};
    internal uint CalculateRequiredExperience()
    {
        return (Hero.Level * (Hero.Level + 1) / 2) * 1000;
    }
    internal void SetModifiers(ref uint targetAbility, params decimal[] modifiers)
    {
        decimal modifier = 0;
        for(int i = 0; i < modifiers.Length; i++)
        {
            modifier += targetAbility * modifiers[i];
        }
        
        targetAbility += (uint)modifier;
    }
	internal void ModifyHealth(int value)
    {
        Hero.Add(value, "Health");
    }
	internal void ModifyMagic(int value)
    {
        Hero.Add(value, "Magic");
    }
	internal void ModifyStamina(int value)
    {
        Hero.Add(value, "Stamina");
    }
	internal void AddExperience(int value)
	{
		Hero.Add (value, "Experience");
	}
	internal void SetMaxHealth(uint value)
    {
        Hero.Set(value, "MaxHealth");
    }
	internal void SetMaxMagic(uint value)
    {
        Hero.Set(value, "MaxMagic");
    }
	internal void SetMaxStamina(uint value)
    {
        Hero.Set(value, "MaxStamina");
    }
	internal void StrengthUp()
    {
        Hero.Up("Strength");
    }
	internal void VitalityUp()
    {
        Hero.Up("Vitality");
        SetMaxHealth(Hero.Abils.Vitality * 5);
    }
	internal void IntelligenceUp()
    {
        Hero.Up("Intelligence");
    }
	internal void WillpowerUp()
    {
        Hero.Up("Willpower");
        SetMaxMagic(Hero.Abils.Willpower * 5);
    }
	internal void DexterityUp()
    {
        Hero.Up("Dexterity");
    }
	internal void EnduranceUp()
    {
        Hero.Up("Endurance");
        SetMaxStamina(Hero.Abils.Endurance * 10);
    }
    }

