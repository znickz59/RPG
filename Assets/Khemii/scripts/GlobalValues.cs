using UnityEngine;
using System.Collections;

public class GlobalValues
{
    public enum Localisation { ENG, UKR };
    private static Localisation localisation = Localisation.ENG;
    public static Localisation Locale
    {
        get { return localisation; }
        set { localisation = value; }
    }
}
