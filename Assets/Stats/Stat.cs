using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField] private float minValue = 0f;
    [SerializeField] private float maxValue = 100f;
    [SerializeField] private float currentValue = 100f;

    public float CurrentValue => currentValue;
    public float MaxValue => maxValue;
    public float MinValue => minValue;

    public bool IsEmpty => currentValue <= minValue;
    public bool IsFull => currentValue >= maxValue;

    public void Increase(float amount)
    {
        currentValue += amount;
        Clamp();
    }

    public void Decrease(float amount)
    {
        currentValue -= amount;
        Clamp();
    }
    
    public void SetValue(float amount)
    {
        currentValue = amount;
        Clamp();
    }

    public void CoinIncrease(float amount)
    {
        currentValue += amount;
    }
    private void Clamp()
    {
        currentValue = Mathf.Clamp(currentValue, minValue, maxValue);
    }

}