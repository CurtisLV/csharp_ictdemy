using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena;

internal class Mage: Warrior
{
    private int mana;
    private int maxMana;
    private int magicDamage;

    public Mage(string name, int health, int damage, int defense, RollingDie die, int mana, int magicDamage): base(name, health, damage, defense, die)
    {
        this.mana = mana;
        this.maxMana = mana;
        this.magicDamage = magicDamage;
    }


    public override void Attack(Warrior enemy)
    {
        int hit = 0;

        // when Mana isn't full
        if (mana < maxMana)
        {
            mana += 10;
            if (mana > maxMana)
            {
                mana = maxMana;
            }
            hit = damage + die.Roll();
            SetMessage($"{name} attacks with a hit worth {hit} HP");
        } else // Magic defense
        {
            hit = magicDamage + die.Roll();
            SetMessage($"{name} attacks with a hit worth {hit} HP");
            mana = 0;
        }
        enemy.Defend(hit);

    }


}
