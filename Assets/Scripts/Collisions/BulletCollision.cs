using System;
using System.Numerics;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private CoinsSpawner coinsSpawner;
    private EntityStats playerStats;
    private Bullet bullet;
    private LifeSteal lifesteal;

    void Start()
    {
        coinsSpawner = GameObject.FindWithTag("CoinsSpawner").GetComponent<CoinsSpawner>();
        playerStats = GameObject.FindWithTag("Player").GetComponent<EntityStats>();
        lifesteal = new LifeSteal(); // do this if gusto mong mag reference ng normal c# script function
        bullet = GetComponent<Bullet>();
        
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
                    bullet.Break(gameObject, 0f);
                    lifesteal.LifeStealBuff(playerStats, 10f);

                    if (zombie.Health.IsEmpty)
                    {
                        coinsSpawner.SaveLastPositionSpawn(zombie.transform.position);
                    }
                }     
            break;

        }
    }

}
