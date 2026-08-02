using System.Collections;
using UnityEngine;
using TMPro;

public class CoinsCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private CoinStat coinStat;

    void Start()
    {
        coinStat = GameObject.FindWithTag("Coins").GetComponent<CoinStat>();
    }
    public void UpdateCoinsText()
    {
       coinText.text = $"Coins: {coinStat.CurrentAmount}"; 
    }

}
