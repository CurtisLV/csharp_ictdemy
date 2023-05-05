namespace Arena;

internal class Warrior
{
    /// <summary>
    /// Warrior's name
    /// </summary>
    protected string name;

    /// <summary>
    /// Health in HP
    /// </summary>
    protected int health;

    /// <summary>
    /// Max health in HP
    /// </summary>
    protected int maxHealth;

    /// <summary>
    ///  Damage in HP
    /// </summary>
    protected int damage;

    /// <summary>
    /// Defense in HP
    /// </summary>
    protected int defense;

    /// <summary>
    /// Rolling dice instance
    /// </summary>
    protected RollingDie die;

    private string message;

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

    public string GraphicalBar(int current, int maximum)
    {
        string s = "";
        int total = 20;
        double count = Math.Round(((double)current / maximum) * total);
        if ((count == 0) && Alive()) // because everything below 2.5% health would be rounded to 0
        {
            count = 1;
        }
        for (int i = 0; i < count; i++)
        {
            s += "█";
        }
        s = s.PadRight(total);

        return s;
    }

    public string HealthBar()
    {
        return GraphicalBar(health, maxHealth);
    }

    public void Defend(int hit)
    {
        int injury = hit - (defense + die.Roll());
        if (injury > 0)
        {
            health -= injury;
            message = $"{name} defended against the attack but still lost {injury} HP";
            if (health <= 0)
            {
                health = 0;
                message += " and died";
            }
        }
        else
        {
            message += $"{name} blocked the hit";
        }

        SetMessage(message);
    }

    public virtual void Attack(Warrior enemy)
    {
        int hit = damage + die.Roll();
        SetMessage($"{name} attacks with a hit worth {hit} HP");
        enemy.Defend(hit);
    }

    protected void SetMessage(string message)
    {
        this.message = message;
    }

    public string GetLastMessage()
    {
        return message;
    }
}
