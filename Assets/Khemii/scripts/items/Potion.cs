using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class Potion : MonoBehaviour , IUsable
{
    //public enum Type { Heal, Poison, Buff, Debuff}
    public static uint Duration;
    public abstract void Use();
}

