using UnityEngine;
using System.Collections;

public class Human : Character
{   
    public static uint Experience { get; set; }
    private static uint RequiredExperience;
    private static uint MaxHealth;
    private static uint MaxMagic;
    private static uint MaxStamina;
    public static CharacterAbilities abilities;
    private void LevelUp()
    {
        Experience -= RequiredExperience;
        Level++;
        RequiredExperience = (Level *(Level + 1) / 2) * 1000;
    }
    private void Check()
    {
        if (Health > MaxHealth) Health = MaxHealth;
        if (Magic > MaxMagic) Magic = MaxMagic;
        if (Stamina > MaxStamina) Stamina = MaxStamina;
    }
    private void Regeneration()
    {
        if (Health < MaxHealth) Health += 1;
        if (Magic < MaxMagic) Magic += 1;
        if (Stamina < MaxStamina) Stamina += 1;
    }
    void Start()
    {
        Health = 0;
        RequiredExperience = (Level * (Level + 1) / 2) * 1000;
    }
    void FixedUpdate()
    {
        if (Experience > RequiredExperience) LevelUp();
        Check();
        Regeneration();
    }

}
