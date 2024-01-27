using DaemonAtribute;
using System;
public enum KindDaemon
{
    Vurdalak, // 0
    Vampire, // 1
    Gul, // 2
    Rita, // 3
    Dracula
}


public abstract class Spirit
{
    public abstract void Passport();
}
public class Monster : Spirit
{
    string name;
    int health, ammo;
    public Monster()
    {
        this.health = 100;
        this.ammo = 100;
        this.name = "Noname";
    }
    public Monster(string name) : this()
    {
        this.name = name;
    }
    public Monster(int health, int ammo, string name)
    {
        this.health = health;
        this.ammo = ammo;
        this.name = name;
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if (value > 0) health = value;
            else health = 0;
        }
    }

    public int Ammo
    {
        get
        {
            return ammo;
        }
        set
        {
            if (value > 0) ammo = value;
            else ammo = 0;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
    }

    override public void Passport()
    {
        Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);
    }
}

[BrainValidation(3)]
public class Daemon : Monster
{
    int brain;
    public int Brain
    {
        get
        {
            return brain;
        }
        set
        {
            if (value > 0) brain = value;
            else brain = 0;
        }
    }

    public Daemon()
    {
        Brain = 1;
    }
    public Daemon(string name, int brain) : base(name)
    {
        this.Brain = brain;
    }
    public Daemon(int health, int ammo, string name, int brain) : base(health, ammo, name)
    {
        this.Brain = brain;
    }
    override public void Passport()
    {
        Console.WriteLine("Daemon {0} \t health = {1} ammo = {2} brain = {3}",
        Name, Health, Ammo, Brain);
    }
    public void Think()
    {
        Console.Write(Name + " is");
        for (int i = 0; i < Brain; ++i) Console.Write(" thinking");
        Console.WriteLine("...");
    }
}