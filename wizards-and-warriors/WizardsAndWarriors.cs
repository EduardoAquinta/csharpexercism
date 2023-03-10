using System;

abstract class Character
{
    
    protected readonly string characterType;

    protected Character(string characterType)
    { 
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return ($"Character is a {characterType}");
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        var damageDealt = target.Vulnerable() ? 10 : 6;
        return damageDealt;
    }
}

class Wizard : Character
{
    private bool preparedSpell;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        var damageDealt = preparedSpell ? 12 : 3;
        return damageDealt;
    }

    public void PrepareSpell()
    {
         preparedSpell = true;
    }

    public override bool Vulnerable() => !preparedSpell;
}
