using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public static uint Level = 1;
    public static string Name{ get; protected set; }    
    public static uint Health { get; set; }
    public static uint Magic { get; set; }
    public static uint Stamina { get; set; }
   // public bool IsNPC { get; }
}
