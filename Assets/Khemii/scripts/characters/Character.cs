using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public static uint Level = 1;
    protected static float health, magic, stamina;
    protected static string Name { get; set; }
    public static float Health { get { return health; } }
    public static float Magic { get { return magic; } }
    public static float Stamina { get { return stamina; } }
    public struct Damage
    {
        public static uint PhysicalDamage;
        public static uint MagicDamage;
        public static uint ArcheryDamage;
    }
    public static uint Defence { get; set; }
    public static void ModifyAttribute(float value, string attributeName)
    {
        switch (attributeName)
        {
            case "Health": health += value; break;
            case "Magic": magic += value; break;
            case "Stamina": stamina += value; break;
            case "Experience": Hero.Experience += value; break;
        }

    }
}
