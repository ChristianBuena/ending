using System;
using System.Collections;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
    [SerializeField] private float timeInterval = 2f;
    [SerializeField] private float damage = 20f;
    private Coroutine damageCoroutine;

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

                    if (player.Health.IsEmpty)
                    {
                        player.Die();
                        Debug.Log("Zombie Killed You");
                    }
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
            Debug.Log($"Zombie -10: Player health: {player.Health.CurrentValue}"); 
            yield return new WaitForSeconds(timeInterval);
        }
    }

}
