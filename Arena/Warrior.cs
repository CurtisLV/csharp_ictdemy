using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena;

internal class Warrior
{
    /// <summary>
    /// Warrior's name
    /// </summary>
    private string name;
    /// <summary>
    /// Health in HP
    /// </summary>
    private int health;
    /// <summary>
    /// Max health in HP
    /// </summary>
    private int maxHealth;
    /// <summary>
    ///  Damage in HP
    /// </summary>
    private int damage;
    /// <summary>
    /// Defense in HP
    /// </summary>
    private int defense;
    /// <summary>
    /// Rolling dice instance
    /// </summary>
    private RollingDie die;

    public Warrior(string name, int health, int damage, int defense, RollingDie die)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
        this.damage = damage;
        this.defense = defense;
        this.die = die;
    }

    public override string ToString()
    {
        return name;
    }

    public bool Alive()
    {
        return (health > 0);
    }

    public string HealthBar()
    {
        string s = "[";
        int total = 20;
        double count = Math.Round(((double)health / maxHealth) * total);
        if ((count == 0) && Alive()) // because everything below 2.5% health would be rounded to 0
        {
            count = 1;
        }
        for (int i = 0; i < count; i++)
        {
            s += "#";
        }
        s = s.PadRight(total + 1);
        s += "]";
        
        return s;
    }


    public void Defend(int hit)
    {
        int injury = hit - (defense + die.Roll());
        if (injury > 0)
        {
            health -= injury;
            if (health <= 0)
            {
                health = 0;
            }
        }
    }

    public void Attack(Warrior enemy)
    {
        int hit = damage + die.Roll();
        enemy.Defend(hit);
    }




}
