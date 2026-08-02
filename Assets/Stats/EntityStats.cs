using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public Stat Health;
    public Stat Speed;
    public Stat Stamina;
    public Stat Strength;

    private HealthCounter healthCounter;

    void Start()
    {
        healthCounter = GameObject.FindWithTag("Canvas").GetComponent<HealthCounter>();
    }

    #region 
    public void TakeDamage(float damage)
    {
        Health.Decrease(damage);
        healthCounter.UpdateHealthText();

        if (Health.IsEmpty)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        Health.Increase(amount);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
    #endregion

}
