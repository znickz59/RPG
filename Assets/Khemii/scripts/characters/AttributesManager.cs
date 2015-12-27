using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Scripting;
public delegate void AttributesChangedEventArgs();
public delegate void AtributesModifyEventArgs(uint value);
    public class AttributesManager
    {
    public event AttributesChangedEventArgs attributeModified = delegate { };
    public uint CalculateRequiredExperience()
    {
        return (Hero.Level * (Hero.Level + 1) / 2) * 1000;
    }
    public void ModifyHealth(uint value)
    {
        Hero.Add(value, "Health");
    }
    public void ModifyMagic(uint value)
    {
        Hero.Add(value, "Magic");
    }
    public void ModifyStamina(uint value)
    {
        Hero.Add(value, "Stamina");
    }
    public void SetMaxHealth(uint value)
    {
        Hero.Set(value, "MaxHealth");
    }
    public void SetMaxMagic(uint value)
    {
        Hero.Set(value, "MaxMagic");
    }
    public void SetMaxStamina(uint value)
    {
        Hero.Set(value, "MaxStamina");
    }
    public void StrengthUp()
    {
        Hero.Up("Strength");
    }
    public void VitalityUp()
    {
        Hero.Up("Vitality");
        SetMaxHealth(Hero.Abils.Vitality * 5);
    }
    public void IntelligenceUp()
    {
        Hero.Up("Intelligence");
    }
    public void WillpowerUp()
    {
        Hero.Up("Willpower");
        SetMaxMagic(Hero.Abils.Willpower * 5);
    }
    public void DexterityUp()
    {
        Hero.Up("Dexterity");
    }
    public void EnduranceUp()
    {
        Hero.Up("Endurance");
        SetMaxStamina(Hero.Abils.Endurance * 10);
    }
    }

