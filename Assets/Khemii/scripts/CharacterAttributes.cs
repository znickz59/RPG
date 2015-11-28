using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class CharacterAttributes
    {
    public uint Force { get; set; }
    public uint Endurance{ get; set; }
    public uint Psycho { get; set; }
    public CharacterAttributes(uint force, uint endurance, uint psycho)
    {
        Force = force;
        Endurance = endurance;
        Psycho = psycho;
    }
    }


