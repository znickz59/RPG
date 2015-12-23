using UnityEngine;
using System.Collections;

public class Hero : Character
{
    public static event AttributesChangedEventArgs attributeChanged = () => { };
    private static uint maxhealth, maxmagix, maxstamina, requiredExperience;
    internal static Abilities abilities = new Abilities(10, 10, 10, 10, 10, 10);
    public static float Experience { get; set; }
    public static uint RequiredExperience { get { return requiredExperience; } }
    public static uint MaxHealth { get { return maxhealth; } }
    public static uint MaxMagic { get { return maxmagix; } }
    public static uint MaxStamina { get { return maxstamina; } }

    public static void ChangeAttribute(uint value, string attributeName)
    {
        switch (attributeName)
        {
            case "RequiredExperience": requiredExperience = value; break;
            case "MaxHealth": maxhealth = value; break;
            case "MaxMagic": maxmagix = value; break;
            case "MaxStamina": maxstamina = value; break;
        }
    }
    
    private void LevelUp()
    {
        Experience -= RequiredExperience;
        Level++;
        attributeChanged();
    }
    private void Check()
    {
        if (Health > MaxHealth) health = MaxHealth;
        if (Magic > MaxMagic) magic = MaxMagic;
        if (Stamina > MaxStamina) stamina = MaxStamina;
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
        Experience = 0;
    }
    void Start()
    {
        attributeChanged();
    }
    void FixedUpdate()
    {
        if (Experience > RequiredExperience) LevelUp();
        Check();
        Regeneration();
    }

}
