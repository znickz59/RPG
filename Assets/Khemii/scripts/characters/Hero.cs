﻿using UnityEngine;
using System.Collections;

public class Hero : Character
{
    AttributesManager am = new AttributesManager();
    private static uint maxhealth, maxmagic, maxstamina, experience, requiredExperience, abilityPoints = 2;
    private static Abilities abilities = new Abilities(10, 10, 10, 10, 10, 10);
    public static Abilities Abils
    {
        get { return abilities; }
    }
    public static float Experience { get { return experience; } }
    public static uint RequiredExperience { get { return requiredExperience; } }
    public static uint AbilityPoints { get { return abilityPoints; } }
    public static uint MaxHealth { get { return maxhealth; } }
    public static uint MaxMagic { get { return maxmagic; } }
    public static uint MaxStamina { get { return maxstamina; } }
    public static void Set(uint value, string name)
    {
        switch (name)
        {
            case "MaxHealth": maxhealth = value; break;
            case "MaxMagic": maxmagic = value; break;
            case "MaxStamina": maxstamina = value; break;
        }
    }
    public static void Add(uint value, string name)
    {
        switch (name)
        {
            case "Health": health += value; break;
            case "Magic": magic += value; break;
            case "Stamina": stamina += value; break;
        }
    }
    public static void Up(string name)
    {
        if (abilityPoints != 0)
        {
            switch (name)
            {
                case "Strength": abilities.Strength++; break;
                case "Vitality": abilities.Vitality++; break;
                case "Intelligence": abilities.Intelligence++; break;
                case "Willpower": abilities.Willpower++; break;
                case "Dexterity": abilities.Dexterity++; break;
                case "Endurance": abilities.Endurance++; break;
            }
            abilityPoints--;
        }
    }
    private void LevelUp()
    {
        experience -= requiredExperience;
        level++;
        requiredExperience = am.CalculateRequiredExperience();
        abilityPoints += 3;
    }
    private void Check()
    {
        if (Health > MaxHealth) health = maxhealth;
        if (Magic > MaxMagic) magic = maxmagic;
        if (Stamina > MaxStamina) stamina = maxstamina;
    }
    private void Regeneration()
    {
        if (Health < MaxHealth) health += Time.fixedDeltaTime; ;
        if (Magic < MaxMagic) magic += Time.fixedDeltaTime;
        if (Stamina < MaxStamina) stamina += Time.fixedDeltaTime;
    }
    void Awake()
    {
        health = 5;
        magic = 10;
        stamina = 15;
        experience = 0;
        am.SetMaxHealth(abilities.Vitality * 5);
        am.SetMaxMagic(abilities.Willpower * 5);
        am.SetMaxStamina(abilities.Endurance * 10);
        requiredExperience = am.CalculateRequiredExperience();
    }
    void Start()
    {
    }
    void FixedUpdate()
    {
        if (Experience > RequiredExperience) LevelUp();
        Check();
        Regeneration();
    }

}
