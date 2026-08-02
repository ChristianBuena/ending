using System;

using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private CoinsSpawner coinsSpawner;

    void Start()
    {
        coinsSpawner = GameObject.FindWithTag("CoinsSpawner").GetComponent<CoinsSpawner>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        String targetTag = collision.gameObject.tag;

        EntityStats zombie = collision.gameObject.GetComponent<EntityStats>();

        switch (targetTag)
        {
            case "Enemy": 
                if(zombie != null)
                {
                    zombie.TakeDamage(20);

                    if (zombie.Health.IsEmpty)
                    {
                        coinsSpawner.SaveLastPosition(transform.position);
                        zombie.Die();
                    }
                }     
            break;

        }
    }

    public void LifeSteal(float life)
    {
    }
}
