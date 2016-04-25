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
        
    }
}

