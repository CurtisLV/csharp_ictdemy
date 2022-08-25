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
    private int magicDefence;

    public Mage(string name, int health, int damage, int defense, RollingDie die, int mana, int magicDefence): base(name, health, damage, defense, die)
    {
        this.mana = mana;
        this.maxMana = mana;
        this.magicDefence = magicDefence;
    }





}
