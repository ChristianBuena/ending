using UnityEngine;

public class CoinStat : MonoBehaviour
{
    [SerializeField] private int minAmount = 0;
    [SerializeField] private int currentAmount = 100;

    public float CurrentAmount => currentAmount;
    public float MinAmount => minAmount;
    public bool IsEmpty => currentAmount <= minAmount;
    private CoinsCounter coinsCounter;

    void Start()
    {
        coinsCounter = GameObject.FindWithTag("Canvas").GetComponent<CoinsCounter>();
    }
    
    public void SetCoinAmount(int amount)
    {
        currentAmount = amount;
        Max();
    }

    public void CoinIncrease(int amount)
    {
        currentAmount += amount;
        coinsCounter.UpdateCoinsText();
        Max();
    }

    public void CoinDecrease(int amount)
    {
        currentAmount -= amount;
        Max();
    }

    private void Max()
    {
        currentAmount = Mathf.Max(currentAmount, minAmount);
    }

}