using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CoinsDrop : MonoBehaviour
{
    [NonSerialized] public CoinStat Coins;
    

    void Start()
    {
      Coins = gameObject.GetComponent<CoinStat>();
    }
    public void CollectCoins(int count, GameObject targetCoin)
    {
        Coins.CoinIncrease(count);
        
        if (targetCoin != null)
        {
            Destroy(targetCoin);
        }
    }

}
