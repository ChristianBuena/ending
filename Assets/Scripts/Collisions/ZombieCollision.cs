using System;
using System.Collections;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
    [SerializeField] private float timeInterval;
    [SerializeField] private float damage;
    private Coroutine damageCoroutine;
    private HealthCounter healthCounter;

    void Start()
    {
        healthCounter = GameObject.FindWithTag("Canvas").GetComponent<HealthCounter>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        String targetTag = collision.gameObject.tag;

        EntityStats player = collision.gameObject.GetComponent<EntityStats>();

        switch (targetTag)
        {
            case "Player": 
                if(player != null)
                {
                    damageCoroutine = StartCoroutine(DamageOverTime(player));
                }
            break;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        String targetTag = collision.gameObject.tag;
        switch (targetTag)
        {
            case "Player":
            if (damageCoroutine != null)
            {
                StopCoroutine(damageCoroutine);
                damageCoroutine = null;
            }
            break;
        }
    }

    IEnumerator DamageOverTime(EntityStats player)
    {
        while (true)
        {
            player.TakeDamage(damage);
            healthCounter.UpdateHealthText();
            Debug.Log($"Zombie -{damage}: Player health: {player.Health.CurrentValue}"); 
            yield return new WaitForSeconds(timeInterval);
        }
    }

}
