using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private CoinsDrop coinSpawn;
    private CoinsCounter coinsCounter;

    void Start()
    {
        coinSpawn = GameObject.FindWithTag("Coins").GetComponent<CoinsDrop>();
        coinsCounter = GameObject.FindWithTag("Canvas").GetComponent<CoinsCounter>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        String targetTag = collision.gameObject.tag;

        switch (targetTag)
        {
            case "Coins":
                coinSpawn.CollectCoins(1, collision.gameObject);
                coinsCounter.UpdateCoinsText();

            break;



        }

    }
}
