using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public delegate void AttributesChangedEventArgs();
public class HeroAttributesChangedListener : MonoBehaviour
{

    void Awake()
    {
        Hero.attributeChanged += OnChanged;
    }

    public void OnDisable()
    {
        Hero.attributeChanged -= OnChanged;
    }

    public void OnChanged()
    {
        Hero.ChangeAttribute(Hero.abilities.Vitality * 5, "MaxHealth");
        Hero.ChangeAttribute(Hero.abilities.Intelligence * 5, "MaxMagic"); ;
        Hero.ChangeAttribute(Hero.abilities.Endurance * 10, "MaxStamina");
        Hero.Damage.PhysicalDamage = Hero.abilities.Strength + Hero.abilities.Dexterity / 5;
        Hero.Damage.MagicDamage = Hero.abilities.Willpower;
        Hero.Damage.ArcheryDamage = Hero.abilities.Dexterity + Hero.abilities.Strength / 5;
        uint formula = (Hero.Level * (Hero.Level + 1) / 2) * 1000;
        Hero.ChangeAttribute(formula, "RequiredExperience");
    }

}

