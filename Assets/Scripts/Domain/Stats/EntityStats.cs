using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public Stat Health;
    public Stat Speed;
    public Stat Stamina;
    public Stat Strength;

    [SerializeField] private GameOverManager gameOverManager;

    #region 
    public void TakeDamage(float damage)
    {
        Health.Decrease(damage);

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
        
        if (gameObject.CompareTag("Player"))
        {
            gameOverManager.GameOver();
            gameObject.SetActive(false);
        }

        Destroy(gameObject);
        
    }
    #endregion

}
