using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class CharacterPerformance
    {
    private uint Health;
    private uint Stamina;
    private uint Vitality;
    private CharacterPerformance(CharacterAttributes characterAttributes)
    {
        Health = characterAttributes.Force / 3 + characterAttributes.Endurance / 3;
        Stamina = characterAttributes.Endurance / 2 + characterAttributes.Force / 2;
        Vitality = characterAttributes.Psycho * (uint)1.5;
    }
    public static CharacterPerformance CalculatePerformance(CharacterAttributes characterAttributes)
    {
        return new CharacterPerformance(characterAttributes);
    }
    }

