using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public abstract class Ability
    {
    protected static uint Progress = 0;
    protected Ability(uint value)
    {
        Progress = value;
    }
    }

public class Strength : Ability
{
    private Strength(uint value) : base(value) { }
    public static implicit operator Strength(uint Value)
    {
        return new Strength(Value);
    }
    public static implicit operator uint(Strength strength)
    {
        return Progress;
    }
    public static Strength operator++(Strength strength)
    {
        return ++Progress;
    }
}
public class Intelect : Ability
{
    private Intelect(uint value) : base(value) { }
    public static implicit operator Intelect(uint Value)
    {
        return new Intelect(Value);
    }
    public static implicit operator uint (Intelect intelect)
    {
        return Progress;
    }
    public static Intelect operator ++(Intelect intelect)
    {
        return ++Progress;
    }
}

public struct CharacterAbilities
{
    public Strength strength;
    public Intelect intelect;
}