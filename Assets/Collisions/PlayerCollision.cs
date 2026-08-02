using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private CoinsDrop coinSpawn;

    void Start()
    {
        coinSpawn = GameObject.FindWithTag("Coins").GetComponent<CoinsDrop>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        String targetTag = collision.gameObject.tag;

        switch (targetTag)
        {
            case "Coins":
                coinSpawn.CollectCoins(1, collision.gameObject);
                Debug.Log($"Collect Coins: {coinSpawn.Coins.CurrentAmount}");

            break;



        }

    }
}
