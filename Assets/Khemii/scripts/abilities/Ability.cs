using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Abilities
    {
    public uint Strength { get; set; }
    public uint Vitality { get; set; }
    public uint Willpower { get; set; }
    public uint Intelligence { get; set; }
    public uint Dexterity { get; set; }
    public uint Endurance { get; set; }
    public Abilities(uint strength, uint vitality, uint willpower, uint intelligence, uint dexterity, uint endurance)
    {
        Strength = strength;
        Vitality = vitality;
        Willpower = willpower;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Endurance = endurance;
    }
    }
