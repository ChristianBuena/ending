using UnityEngine;

public class ResourceStats : MonoBehaviour
{
    [SerializeField] private int minAmount = 0;
    [SerializeField] private int currentAmount = 100;

    public int CurrentAmount => currentAmount;
    public int MinAmount => minAmount;
    public bool IsEmpty => currentAmount <= minAmount;
  
    public void SetResourceAmount(int amount)
    {
        currentAmount = amount;

        Max();
    }

    public void ResourceIncrease(int amount)
    {
        currentAmount += amount;
        Max();
    }

    public void ResourceDecrease(int amount)
    {
        currentAmount -= amount;
        Max();
    }

    private void Max()
    {
        currentAmount = Mathf.Max(currentAmount, minAmount);
    }

}