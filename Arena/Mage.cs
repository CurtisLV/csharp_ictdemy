namespace Arena;

internal class Mage : Warrior
{
    private int mana;
    private int maxMana;
    private int magicDamage;

    public Mage(
        string name,
        int health,
        int damage,
        int defense,
        RollingDie die,
        int mana,
        int magicDamage
    )
        : base(name, health, damage, defense, die)
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
            base.Attack(enemy); // if we are not using mana, we just use Base's Attack method
        }
        else // Magic damage
        {
            hit = magicDamage + die.Roll();
            SetMessage($"{name} attacks with a hit worth {hit} HP");
            enemy.Defend(hit);
            mana = 0;
        }
    }

    public string ManaBar()
    {
        return GraphicalBar(mana, maxMana);
    }
}
