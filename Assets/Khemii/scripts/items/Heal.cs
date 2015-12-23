using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Heal : Potion
{
    public enum Type { Health, Magic, Stamina}
    public Type type;
    public uint Effect;
    void Start()
    {
       
    }

    void FixedUpdate()
    {

    }
    void OnMouseUp()
    {
        Use();
    }
    public override void Use()
    {
        switch (type)
        {
            case Type.Health: Hero.ModifyAttribute(Effect, "Health"); break;
            case Type.Magic: Hero.ModifyAttribute(Effect, "Magic"); break;
            case Type.Stamina: Hero.ModifyAttribute(Effect, "Stamina"); break;
            default: Hero.ModifyAttribute(-50, "Health"); break;
        }
        Destroy(gameObject);
    }
}

