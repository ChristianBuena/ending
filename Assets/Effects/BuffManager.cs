using UnityEngine;

public class BuffManager: MonoBehaviour
{
        // Ito ang "Instance" para matawag ito kahit saan nang walang GetComponent
    public static BuffManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void LifeStealBuff(EntityStats targetStats, float amount)
    {
        targetStats.Heal(amount);
    }
}
