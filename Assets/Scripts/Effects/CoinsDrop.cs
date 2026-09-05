using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CoinsDrop : MonoBehaviour
{
    [NonSerialized] public ResourceStats Coins;

    void Start()
    {
      Coins = gameObject.GetComponent<ResourceStats>();
    }
    public void CollectCoins(int count, GameObject targetCoin)
    {
        Coins.ResourceIncrease(count);
        if (targetCoin != null)
        {
            Destroy(targetCoin);
        }
    }

}
