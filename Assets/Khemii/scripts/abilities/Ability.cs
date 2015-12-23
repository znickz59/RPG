using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Abilities
    {
    public uint Strength;
    public uint Vitality;
    public uint Willpower;
    public uint Intelligence;
    public uint Dexterity;
    public uint Endurance;
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
