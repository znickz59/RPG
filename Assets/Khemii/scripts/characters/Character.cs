﻿using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected static uint level = 1;
    protected static float health, magic, stamina;
    protected static string Name { get; set; }
    public static float Health { get { return health; } }
    public static float Magic { get { return magic; } }
    public static float Stamina { get { return stamina; } }
    public static uint Level { get { return level; } }
}
