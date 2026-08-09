public class LifeSteal
{
    public void LifeStealBuff(EntityStats targetStats, float amount)
    {
        targetStats.Heal(amount);
    }
}

